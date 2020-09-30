using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using jk760216_MIS4200.DAL;
using jk760216_MIS4200.Models;

namespace jk760216_MIS4200.Controllers
{
    public class AppointmentsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Appointments
        public ActionResult Index()
        {
            var appointment = db.Appointment.Include(a => a.Doctor).Include(a => a.Patient);
            return View(appointment.ToList());
        }

        // GET: Appointments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointments appointments = db.Appointment.Find(id);
            if (appointments == null)
            {
                return HttpNotFound();
            }
            return View(appointments);
        }

        // GET: Appointments/Create
        public ActionResult Create()
        {
            ViewBag.doctorID = new SelectList(db.Doctor, "doctorID", "firstName");
            ViewBag.patientID = new SelectList(db.Patient, "patientID", "firstName");
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AppointmentID,time,patientID,doctorID")] Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                db.Appointment.Add(appointments);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.doctorID = new SelectList(db.Doctor, "doctorID", "firstName", appointments.doctorID);
            ViewBag.patientID = new SelectList(db.Patient, "patientID", "firstName", appointments.patientID);
            return View(appointments);
        }

        // GET: Appointments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointments appointments = db.Appointment.Find(id);
            if (appointments == null)
            {
                return HttpNotFound();
            }
            ViewBag.doctorID = new SelectList(db.Doctor, "doctorID", "firstName", appointments.doctorID);
            ViewBag.patientID = new SelectList(db.Patient, "patientID", "firstName", appointments.patientID);
            return View(appointments);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AppointmentID,time,patientID,doctorID")] Appointments appointments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.doctorID = new SelectList(db.Doctor, "doctorID", "firstName", appointments.doctorID);
            ViewBag.patientID = new SelectList(db.Patient, "patientID", "firstName", appointments.patientID);
            return View(appointments);
        }

        // GET: Appointments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointments appointments = db.Appointment.Find(id);
            if (appointments == null)
            {
                return HttpNotFound();
            }
            return View(appointments);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appointments appointments = db.Appointment.Find(id);
            db.Appointment.Remove(appointments);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
