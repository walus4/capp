using System;

namespace Capgemini.Domain.DTO
{
    public class CustormerDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string NIP { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HauseNo { get; set; }
        public string AppartamentNo { get; set; }
        public bool SalesActive { get; set; }
    }
}