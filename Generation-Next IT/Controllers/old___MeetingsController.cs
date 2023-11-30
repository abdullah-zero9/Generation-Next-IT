using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MonjurTask.Models;

namespace MonjurTask.Controllers
{
    // Controller
    //public class MeetingsController : Controller
    //{
    //    private readonly MeetingDbContext _context;

    //    public MeetingsController(MeetingDbContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: Meetings
    //    public IActionResult Index()
    //    {
    //        var meetings = _context.Meetings
    //            .Include(m => m.Customer)
    //            .Include(m => m.MeetingDetails)
    //                .ThenInclude(md => md.ProductService)
    //            .ToList();

    //        return View(meetings);
    //    }

    //    // GET: Meetings/Create
    //    public IActionResult Create()
    //    {
    //        var viewModel = new MeetingViewModel
    //        {
    //            MeetingDetails = new List<MeetingDetailViewModel> { new MeetingDetailViewModel() }
    //        };

    //        // Populate dropdowns for Customer and ProductService
    //        viewModel.CustomerList = new SelectList(_context.Customers, "CustomerId", "CustomerName");
    //        viewModel.ProductServiceList = new SelectList(_context.ProductServices, "ProductServiceId", "ProductServiceName");

    //        return View(viewModel);
    //    }

    //    // POST: Meetings/Create
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public IActionResult Create(MeetingViewModel viewModel)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var meeting = new Meeting
    //            {
    //                // Map properties from the ViewModel to the Meeting model
    //                IsCorporate = viewModel.IsCorporate,
    //                IsIndividual = viewModel.IsIndividual,
    //                CustomerId = viewModel.CustomerId,
    //                Date = viewModel.Date,
    //                Time = viewModel.Time,
    //                MeetingPlace = viewModel.MeetingPlace,
    //                AttendsFromClient = viewModel.AttendsFromClient,
    //                AttendsFromHost = viewModel.AttendsFromHost,
    //                Agenda = viewModel.Agenda,
    //                Discussion = viewModel.Discussion,
    //                Decision = viewModel.Decision,
    //            };

    //            foreach (var detailViewModel in viewModel.MeetingDetails)
    //            {
    //                var meetingDetail = new MeetingDetail
    //                {
    //                    // Map properties from the MeetingDetailViewModel to the MeetingDetail model
    //                    Quantity = detailViewModel.Quantity,
    //                    Unit = detailViewModel.Unit,
    //                    MeetingId = meeting.MeetingId, // Set the foreign key
    //                    ProductServiceId = detailViewModel.ProductServiceId // Set the foreign key
    //                };

    //                meeting.MeetingDetails.Add(meetingDetail);
    //            }

    //            _context.Meetings.Add(meeting);
    //            _context.SaveChanges();
    //            return RedirectToAction(nameof(Index));
    //        }

    //        // Repopulate dropdowns in case of validation errors
    //        viewModel.CustomerList = new SelectList(_context.Customers, "CustomerId", "CustomerName", viewModel.CustomerId);
    //        viewModel.ProductServiceList = new SelectList(_context.ProductServices, "ProductServiceId", "ProductServiceName");

    //        return View(viewModel);
    //    }

    //}
}






//new scaffold
//
//// GET: MeetingMinuteMasters
//public async Task<IActionResult> Index()
//{
//    var applicationDbContext = _context.Meeting_Minutes_Master_Tbl
//        .Include(m => m.CorporateCustomer)
//        .Include(m => m.IndividualCustomer)
//        .Include(m => m.MeetingMinuteDetails)
//        .ToList();

//    return View(await applicationDbContext.ToListAsync());
//}

//// GET: MeetingMinuteMasters/Details/5
//public async Task<IActionResult> Details(int? id)
//{
//    if (id == null || _context.Meeting_Minutes_Master_Tbl == null)
//    {
//        return NotFound();
//    }

//    var meetingMinuteMaster = await _context.Meeting_Minutes_Master_Tbl
//        .Include(m => m.CorporateCustomer)
//        .Include(m => m.IndividualCustomer)
//        .FirstOrDefaultAsync(m => m.MeetingMinuteMasterID == id);
//    if (meetingMinuteMaster == null)
//    {
//        return NotFound();
//    }

//    return View(meetingMinuteMaster);
//}

//// GET: MeetingMinuteMasters/Create
//public IActionResult Create()
//{
//    ViewData["CorporateCustomerID"] = new SelectList(_context.Corporate_Customer_Tbl, "CorporateCustomerID", "CorporateCustomerName");
//    ViewData["IndividualCustomerID"] = new SelectList(_context.Individual_Customer_Tbl, "IndividualCustomerID", "IndividualCustomerName");
//    return View();
//}

//// POST: MeetingMinuteMasters/Create
//// To protect from overposting attacks, enable the specific properties you want to bind to.
//// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> Create([Bind("MeetingMinuteMasterID,CustomerType,CorporateCustomerID,IndividualCustomerID,Date,MeetingPlace,AttendsFromClient,AttendsFromHost,Agenda,Discussion,Decision")] MeetingMinuteMaster meetingMinuteMaster)
//{
//    if (ModelState.IsValid)
//    {
//        _context.Add(meetingMinuteMaster);
//        await _context.SaveChangesAsync();
//        return RedirectToAction(nameof(Index));
//    }
//    ViewData["CorporateCustomerID"] = new SelectList(_context.Corporate_Customer_Tbl, "CorporateCustomerID", "CorporateCustomerName", meetingMinuteMaster.CorporateCustomerID);
//    ViewData["IndividualCustomerID"] = new SelectList(_context.Individual_Customer_Tbl, "IndividualCustomerID", "IndividualCustomerName", meetingMinuteMaster.IndividualCustomerID);
//    return View(meetingMinuteMaster);
//}

//// GET: MeetingMinuteMasters/Edit/5
//public async Task<IActionResult> Edit(int? id)
//{
//    if (id == null || _context.Meeting_Minutes_Master_Tbl == null)
//    {
//        return NotFound();
//    }

//    var meetingMinuteMaster = await _context.Meeting_Minutes_Master_Tbl.FindAsync(id);
//    if (meetingMinuteMaster == null)
//    {
//        return NotFound();
//    }
//    ViewData["CorporateCustomerID"] = new SelectList(_context.Corporate_Customer_Tbl, "CorporateCustomerID", "CorporateCustomerName", meetingMinuteMaster.CorporateCustomerID);
//    ViewData["IndividualCustomerID"] = new SelectList(_context.Individual_Customer_Tbl, "IndividualCustomerID", "IndividualCustomerName", meetingMinuteMaster.IndividualCustomerID);
//    return View(meetingMinuteMaster);
//}

//// POST: MeetingMinuteMasters/Edit/5
//// To protect from overposting attacks, enable the specific properties you want to bind to.
//// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> Edit(int id, [Bind("MeetingMinuteMasterID,CustomerType,CorporateCustomerID,IndividualCustomerID,Date,MeetingPlace,AttendsFromClient,AttendsFromHost,Agenda,Discussion,Decision")] MeetingMinuteMaster meetingMinuteMaster)
//{
//    if (id != meetingMinuteMaster.MeetingMinuteMasterID)
//    {
//        return NotFound();
//    }

//    if (ModelState.IsValid)
//    {
//        try
//        {
//            _context.Update(meetingMinuteMaster);
//            await _context.SaveChangesAsync();
//        }
//        catch (DbUpdateConcurrencyException)
//        {
//            if (!MeetingMinuteMasterExists(meetingMinuteMaster.MeetingMinuteMasterID))
//            {
//                return NotFound();
//            }
//            else
//            {
//                throw;
//            }
//        }
//        return RedirectToAction(nameof(Index));
//    }
//    ViewData["CorporateCustomerID"] = new SelectList(_context.Corporate_Customer_Tbl, "CorporateCustomerID", "CorporateCustomerName", meetingMinuteMaster.CorporateCustomerID);
//    ViewData["IndividualCustomerID"] = new SelectList(_context.Individual_Customer_Tbl, "IndividualCustomerID", "IndividualCustomerName", meetingMinuteMaster.IndividualCustomerID);
//    return View(meetingMinuteMaster);
//}

//// GET: MeetingMinuteMasters/Delete/5
//public async Task<IActionResult> Delete(int? id)
//{
//    if (id == null || _context.Meeting_Minutes_Master_Tbl == null)
//    {
//        return NotFound();
//    }

//    var meetingMinuteMaster = await _context.Meeting_Minutes_Master_Tbl
//        .Include(m => m.CorporateCustomer)
//        .Include(m => m.IndividualCustomer)
//        .FirstOrDefaultAsync(m => m.MeetingMinuteMasterID == id);
//    if (meetingMinuteMaster == null)
//    {
//        return NotFound();
//    }

//    return View(meetingMinuteMaster);
//}

//// POST: MeetingMinuteMasters/Delete/5
//[HttpPost, ActionName("Delete")]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> DeleteConfirmed(int id)
//{
//    if (_context.Meeting_Minutes_Master_Tbl == null)
//    {
//        return Problem("Entity set 'ApplicationDbContext.Meeting_Minutes_Master_Tbl'  is null.");
//    }
//    var meetingMinuteMaster = await _context.Meeting_Minutes_Master_Tbl.FindAsync(id);
//    if (meetingMinuteMaster != null)
//    {
//        _context.Meeting_Minutes_Master_Tbl.Remove(meetingMinuteMaster);
//    }

//    await _context.SaveChangesAsync();
//    return RedirectToAction(nameof(Index));
//}

//private bool MeetingMinuteMasterExists(int id)
//{
//  return (_context.Meeting_Minutes_Master_Tbl?.Any(e => e.MeetingMinuteMasterID == id)).GetValueOrDefault();
//}