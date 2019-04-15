﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DpsApis.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DpsApis.Controllers
{
    [Route("DpsApi/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {


        // GET: DpsApi/Customer
        [HttpGet]       
        public async Task<ActionResult<List<CustomerFromOneVM>>> GetCustomersAsync()
        {
            try
            {
                List<CustomerFromOneVM> CustomersList = new List<CustomerFromOneVM>();

                Customerdetail customerdetail1 = new Customerdetail();
                customerdetail1.vatnumber = "123";
                customerdetail1.checkcheck = true;
                customerdetail1.creditlimt = 123;
                customerdetail1.customername = "customername";
                customerdetail1.officialname = "officialname";
                customerdetail1.legalform = "legalform";
                customerdetail1.street = "street";
                customerdetail1.streetno = 123;
                customerdetail1.bus = "bus";
                customerdetail1.place = "place";
                customerdetail1.postal = 123;
                customerdetail1.country = "country";
                customerdetail1.telephone = "telephone";
                customerdetail1.generalEmail = "generalEmail";
                customerdetail1.billingEmail = "billingEmail";
                customerdetail1.contractEmail = "contractEmail";

                Contactdetail contactdetail1 = new Contactdetail();
                contactdetail1.lastName = "lastName";
                contactdetail1.language = "language";
                contactdetail1.position = "position";
                contactdetail1.contactEmail = "contactEmail";
                contactdetail1.mobileNumber = "mobileNumber";
                contactdetail1.telephone = "telephone";
                contactdetail1.createAsUser = true;
                contactdetail1.mobileNumber = "mobileNumber";

                CustomerFromOneVM customerVM1 = new CustomerFromOneVM();
                customerVM1.userid = 123;
                customerVM1.customerdetail = customerdetail1;
                customerVM1.contactDetail = contactdetail1;


                CustomersList.Add(customerVM1);
                CustomersList.Add(customerVM1);

                return Ok(CustomersList);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // GET: DpsApi/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerFromOneVM>> GetCustomerByIdAsync(int id)
        {
            Customerdetail customerdetail1 = new Customerdetail();
            customerdetail1.vatnumber = "123";
            customerdetail1.checkcheck = true;
            customerdetail1.creditlimt = 123;
            customerdetail1.customername = "customername";
            customerdetail1.officialname = "officialname";
            customerdetail1.legalform = "legalform";
            customerdetail1.street = "street";
            customerdetail1.streetno = 123;
            customerdetail1.bus = "bus";
            customerdetail1.place = "place";
            customerdetail1.postal = 123;
            customerdetail1.country = "country";
            customerdetail1.telephone = "telephone";
            customerdetail1.generalEmail = "generalEmail";
            customerdetail1.billingEmail = "billingEmail";
            customerdetail1.contractEmail = "contractEmail";

            Contactdetail contactdetail1 = new Contactdetail();

            contactdetail1.lastName = "lastName";
            contactdetail1.language = "language";
            contactdetail1.position = "position";
            contactdetail1.contactEmail = "contactEmail";
            contactdetail1.mobileNumber = "mobileNumber";
            contactdetail1.telephone = "telephone";
            contactdetail1.createAsUser = true;
            contactdetail1.mobileNumber = "mobileNumber";

            CustomerFromOneVM customerVM1 = new CustomerFromOneVM();
            customerVM1.userid = 123;
            customerVM1.customerdetail = customerdetail1;
            customerVM1.contactDetail = contactdetail1;

            return Ok(customerVM1);
        }

        // GET: DpsApi/Customer/WorkSchedules
        [HttpGet]
        [Route("WorkSchedules")]
        public async Task<ActionResult<CustomerWorkScheduleVM>> GetWorkSchedulesAsync()
        {
            //List<CustomerWorkScheduleVM> workSchedulesList = new List<CustomerWorkScheduleVM>();

            List<WorkTimeVM> workTimeList = new List<WorkTimeVM>();
            WorkTimeVM workTimeVM = new WorkTimeVM();
            workTimeList.Add(workTimeVM);

            List<BreakTimeVM> breakTimesList = new List<BreakTimeVM>();
            BreakTimeVM breakTimeVM = new BreakTimeVM();           
            breakTimesList.Add(breakTimeVM);

            

            WorkDayVM workDayVM1 = new WorkDayVM();
            workDayVM1.DayOfWeek = 1;
            workDayVM1.WorkTimes = workTimeList;
            workDayVM1.BreakTime = breakTimesList;

            WorkDayVM workDayVM2 = new WorkDayVM();
            workDayVM2.DayOfWeek = 2;
            workDayVM2.WorkTimes = workTimeList;
            workDayVM2.BreakTime = breakTimesList;

            WorkDayVM workDayVM3 = new WorkDayVM();
            workDayVM3.DayOfWeek = 3;
            workDayVM3.WorkTimes = workTimeList;
            workDayVM3.BreakTime = breakTimesList;

            WorkDayVM workDayVM4 = new WorkDayVM();
            workDayVM4.DayOfWeek = 4;
            workDayVM4.WorkTimes = workTimeList;
            workDayVM4.BreakTime = breakTimesList;

            WorkDayVM workDayVM5 = new WorkDayVM();
            workDayVM5.DayOfWeek = 5;
            workDayVM5.WorkTimes = workTimeList;
            workDayVM5.BreakTime = breakTimesList;

            List<WorkDayVM> workDayList = new List<WorkDayVM>();
            workDayList.Add(workDayVM1);
            workDayList.Add(workDayVM2);
            workDayList.Add(workDayVM3);
            workDayList.Add(workDayVM4);
            workDayList.Add(workDayVM5);

            WorkScheduleVM workSchedule = new WorkScheduleVM();
            workSchedule.WorkDays = workDayList;

            CustomerWorkScheduleVM workSchedules = new CustomerWorkScheduleVM();
            workSchedules.WorkSchedule = workSchedule;


            return Ok(workSchedules);

        }

        // GET: DpsApi/Customer/Positions
        [HttpGet]
        [Route("Positions")]
        public async Task<ActionResult<CustomerPostionVM>> GetPositionsAsync()
        {
            List<CustomerPostionVM> postionsList = new List<CustomerPostionVM>();
            CustomerPostionVM customerPostion = new CustomerPostionVM();
            postionsList.Add(customerPostion);
            postionsList.Add(customerPostion);
            postionsList.Add(customerPostion);
            return Ok(postionsList);

        }

        // GET: DpsApi/Customer/Locations
        [HttpGet]
        [Route("Locations")]
        public async Task<ActionResult<CustomerLocationVM>> GetLocationsAsync()
        {
            List<CustomerLocationVM> locationsList = new List<CustomerLocationVM>();
            CustomerLocationVM customerLocation = new CustomerLocationVM();
            locationsList.Add(customerLocation);
            locationsList.Add(customerLocation);
            locationsList.Add(customerLocation);
            locationsList.Add(customerLocation);
            return Ok(locationsList);

        }

        // POST: DpsApi/Customer/CreateCustomerForm1
        [HttpPost]
        [Route("CreateCustomerForm1")]
        public async Task<ActionResult> CreateCustomerForm1Async(CustomerFromOneVM model)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {                   
                    return Ok(model.userid);
                }
                catch (Exception e)
                {
                    Trace.TraceError(e.Message);
                    // return we have an internal error ...
                    return StatusCode(500);
                }
            }

        }


        // POST: DpsApi/Customer/CreateCustomerForm2
        [HttpPost]
        [Route("CreateCustomerForm2")]
        public async Task <ActionResult> CreateCustomerForm2Async(CustomerVM model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    return Ok();
                }
                catch (Exception e)
                {
                    Trace.TraceError(e.Message);
                    // return we have an internal error ...
                    return StatusCode(500);
                }
            }

        }

        // POST: DpsApi/Customer/Update
        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult> UpdateCustomerAsync(CustomerVM model)
        {
            return Ok(model);
        }

        // POST: DpsApi/Customer/Archive
        [HttpPost]
        [Route("Archive")]
        public async Task<ActionResult> ArchiveCustomerAsync(CustomerVM model)
        {
            return Ok(model);
        }

    }
    public class CustomerVM
    {
        //public Guid Id { get; set; } = Guid.NewGuid();
        public string VATNumber { get; set; } 
        public string Name { get; set; } = "Name";
        public string OfficialName { get; set; } = "OfficialName";
        public string LegalForm { get; set; } = "Abc";
        public CreditCheckVM CreditCheck { get; set; } = new CreditCheckVM();
        public string Address { get; set; } = "Qwerty";
        public string PhoneNumber { get; set; } = "+971557142152";
        public string Email { get; set; } = "Qwerty@abc.com";
        public VCACertificationVM VCACertification { get; set; } = new VCACertificationVM();

    }

    public class VCACertificationVM
    {
        public bool Certified { get; set; } = true;
    }

    public class CustomerWorkScheduleVM
    {
        public Guid CustomerId { get; set; } =  Guid.NewGuid();
        public string Name { get; set; } = "Qwerty";
        public WorkScheduleVM WorkSchedule   { get; set; } = new WorkScheduleVM();
        public bool IsEnabled { get; set; } = true;
        public bool IsArchived { get; set; } = false;
    }

    public class WorkScheduleVM
    {
        public List<WorkDayVM> WorkDays { get; set; } = new List<WorkDayVM>();
    }

    public class WorkDayVM
    {
        public int DayOfWeek { get; set; } = DateTime.Now.Day;
        public List<WorkTimeVM> WorkTimes { get; set; } = new List<WorkTimeVM>();
        public List<BreakTimeVM> BreakTime { get; set; } = new List<BreakTimeVM>();
    }

    public class BreakTimeVM
    {
        public TimeSpan TimeSpan { get; set; } = new TimeSpan(2, 0, 0);
    }

    public class WorkTimeVM
    {
        public TimeSpan TimeSpan { get; set; } = new TimeSpan(8, 0, 0);
    }

    public class CustomerPostionVM
    {
        public Guid CustomerId { get; set; } =  Guid.NewGuid();
        public PositionVM Position { get; set; } = new PositionVM();
        public bool IsEnabled { get; set; } = true;
        public bool IsArchived { get; set; } = false;
    }

    public class PositionVM
    {
        public string Name { get; set; } = "PositionName";
        public string TaskDescription { get; set; } = "TaskDescription";
        public bool IsStudentAllowed { get; set; } = true;
        public string CostCenter { get; set; } = "CostCenter";
        public DocumentVM WorkStationDocument { get; set; } 
    }

    public class DocumentVM
    {
    }

    public class CustomerLocationVM
    {
        public Guid CustomerId { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "Name";
        public AddressVM Address { get; set; } = new AddressVM();
        public bool IsEnabled { get; set; } = true;
        public bool IsArchived { get; set; } = false;
    }

    public class AddressVM
    {
        public string Street { get; set; } = "Street";
        public string StreetNumber { get; set; } = "StreetNumber";
        public string Bus { get; set; } = "Bus";
        public string City { get; set; } = "City";
        public string PostalCode { get; set; } = "PostalCode";
        public string Country { get; set; } = "Country";
        public string CountryCode { get; set; } = "Country";
    }

    public class CreditCheckVM
    {
        public bool CreditWorthy { get; set; } = true;
        public double CreditLimit { get; set; } = 100000;
        public DateTime DateChecked { get; set; } = DateTime.Now.AddMonths(-3).Date;

        public bool CreditCheck(string VATNumber)
        {
            return true;
        }
    }
}


