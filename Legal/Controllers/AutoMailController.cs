using Codaxy.WkHtmlToPdf;
using Legal.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Transactions;
using System.Web;
using System.Web.Mvc;

namespace Legal.Controllers
{
    public class AutoMailController : Controller
    {
        //
        // GET: /Print/
        private LegalMailerContext db = new LegalMailerContext();
        DateTime CurrentDate = DateTime.Now.Date;

        public ActionResult Index()
        {
            var outParam = new SqlParameter
            {
                ParameterName = "@result",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Int
            };

            List<Boolean> _BUEvent = db.Database.SqlQuery<Boolean>("sp_InsertIntoBuEventLog @result OUT", outParam).ToList();

            using (TransactionScope transaction = new TransactionScope())
            {
                
                bool result = _BUEvent.FirstOrDefault();
                if (result)
                {
                    var _vwSendEmail = (db.vwSendEmails.Where(a => a.CREATEDDATE == CurrentDate).Select(a => new { a.KDKC, a.email, a.NMKC,a.TAHUN,a.BULAN,a.MINGGU })).Distinct();
                    int count = 0;
                    foreach(var sending in _vwSendEmail)
                    {
                        MemoryStream memory = new MemoryStream();
                        PdfDocument document = new PdfDocument() { Url = string.Format("http://localhost:1815/AutoMail/PreviewPage?kdkc={0}", sending.KDKC) };
                        PdfOutput output = new PdfOutput() { OutputStream = memory };

                        PdfConvert.ConvertHtmlToPdf(document, output);
                        memory.Position = 0;
                        var SubjectName = string.Format("Reminder Masa Habis PKS Badan Usaha T{0} B{1} M{2}", sending.TAHUN, sending.BULAN, sending.MINGGU);
                        var attchName = string.Format("ReminderMasaHabisPKSBadanUsahaT{0}B{1}M{2}", sending.TAHUN, sending.BULAN, sending.MINGGU);
                        ContentType ct = new ContentType(MediaTypeNames.Application.Pdf);
                        Attachment data = new Attachment(memory, ct);
                        data.Name = attchName;
                        MailMessage message = new MailMessage();
                        message.To.Add(new MailAddress(sending.email));
                        message.From = new MailAddress("irfan.kacrut@gmail.com", "Legal-InHealth Reminder ");
                        message.Subject = SubjectName;
                        message.Attachments.Add(data);
                        message.Body = sending.NMKC;
                        SmtpClient client = new SmtpClient();
                        
                        try
                        {
                            client.Send(message);
                        }
                        catch (Exception ex)
                        {
                            
                            ViewData["SendingException"] = string.Format("Exception caught in SendErrorLog: {0}",ex.ToString());
                            return View("ErrorSending", ViewData["SendingException"]);
                        }
                        data.Dispose();
                        // Close the log file.
                        memory.Close();
                        count += 1;
                    }
                }
                transaction.Complete();
            }
            return View();
        }

        public ActionResult Print()
        {
            var printRequest = db.BUEventLogs.ToList();

            if (printRequest == null)
            {
                return RedirectToAction("PerjadinNotRelease");
            }
            else
            {
                MemoryStream memory = new MemoryStream();
                var PrintPageUrl = ConfigurationManager.AppSettings["PrintRequest"];
                PdfDocument document = new PdfDocument() { Url = string.Format("http://localhost:1815/Print/PreviewPage/") };
                PdfOutput output = new PdfOutput() { OutputStream = memory };

                PdfConvert.ConvertHtmlToPdf(document, output);
                memory.Position = 0;

                return File(memory, "application/pdf", Server.UrlEncode("BUNotif.pdf"));
            }
        }


        public ActionResult PreviewPage(string KDKC)
        {
            return View(db.vwSendEmails.Where(a => a.CREATEDDATE == CurrentDate && a.KDKC == KDKC).OrderBy(a=>a.PKSNM).ToList());
        }

        public ViewResult ErrorSending()
        {
            return View(ViewData["SendingException"]);
        }

    }
}
