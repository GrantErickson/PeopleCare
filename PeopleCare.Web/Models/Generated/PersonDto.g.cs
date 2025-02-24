using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class PersonParameter : GeneratedParameterDto<PeopleCare.Data.Models.Person>
    {
        public PersonParameter() { }

        private string _PersonId;
        private string _RegionId;
        private string _UserId;
        private PeopleCare.Data.Models.Person.Sex? _SexAssignedAtBirth;
        private string _FirstName;
        private string _LastName;
        private string _Email;
        private string _Phone;
        private string _StreetAddress;
        private string _City;
        private string _State;
        private string _Zip;
        private string _Country;
        private System.DateOnly? _DateOfBirth;
        private int? _EthnicityId;
        private string _CountryOfOrigin;
        private string _CityOfOrigin;
        private string _GenderId;
        private string _PointPersonId;
        private string _Notes;

        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string RegionId
        {
            get => _RegionId;
            set { _RegionId = value; Changed(nameof(RegionId)); }
        }
        public string UserId
        {
            get => _UserId;
            set { _UserId = value; Changed(nameof(UserId)); }
        }
        public PeopleCare.Data.Models.Person.Sex? SexAssignedAtBirth
        {
            get => _SexAssignedAtBirth;
            set { _SexAssignedAtBirth = value; Changed(nameof(SexAssignedAtBirth)); }
        }
        public string FirstName
        {
            get => _FirstName;
            set { _FirstName = value; Changed(nameof(FirstName)); }
        }
        public string LastName
        {
            get => _LastName;
            set { _LastName = value; Changed(nameof(LastName)); }
        }
        public string Email
        {
            get => _Email;
            set { _Email = value; Changed(nameof(Email)); }
        }
        public string Phone
        {
            get => _Phone;
            set { _Phone = value; Changed(nameof(Phone)); }
        }
        public string StreetAddress
        {
            get => _StreetAddress;
            set { _StreetAddress = value; Changed(nameof(StreetAddress)); }
        }
        public string City
        {
            get => _City;
            set { _City = value; Changed(nameof(City)); }
        }
        public string State
        {
            get => _State;
            set { _State = value; Changed(nameof(State)); }
        }
        public string Zip
        {
            get => _Zip;
            set { _Zip = value; Changed(nameof(Zip)); }
        }
        public string Country
        {
            get => _Country;
            set { _Country = value; Changed(nameof(Country)); }
        }
        public System.DateOnly? DateOfBirth
        {
            get => _DateOfBirth;
            set { _DateOfBirth = value; Changed(nameof(DateOfBirth)); }
        }
        public int? EthnicityId
        {
            get => _EthnicityId;
            set { _EthnicityId = value; Changed(nameof(EthnicityId)); }
        }
        public string CountryOfOrigin
        {
            get => _CountryOfOrigin;
            set { _CountryOfOrigin = value; Changed(nameof(CountryOfOrigin)); }
        }
        public string CityOfOrigin
        {
            get => _CityOfOrigin;
            set { _CityOfOrigin = value; Changed(nameof(CityOfOrigin)); }
        }
        public string GenderId
        {
            get => _GenderId;
            set { _GenderId = value; Changed(nameof(GenderId)); }
        }
        public string PointPersonId
        {
            get => _PointPersonId;
            set { _PointPersonId = value; Changed(nameof(PointPersonId)); }
        }
        public string Notes
        {
            get => _Notes;
            set { _Notes = value; Changed(nameof(Notes)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Person entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(RegionId))) entity.RegionId = RegionId;
            if (ShouldMapTo(nameof(UserId))) entity.UserId = UserId;
            if (ShouldMapTo(nameof(SexAssignedAtBirth))) entity.SexAssignedAtBirth = (SexAssignedAtBirth ?? entity.SexAssignedAtBirth);
            if (ShouldMapTo(nameof(FirstName))) entity.FirstName = FirstName;
            if (ShouldMapTo(nameof(LastName))) entity.LastName = LastName;
            if (ShouldMapTo(nameof(Email))) entity.Email = Email;
            if (ShouldMapTo(nameof(Phone))) entity.Phone = Phone;
            if (ShouldMapTo(nameof(StreetAddress))) entity.StreetAddress = StreetAddress;
            if (ShouldMapTo(nameof(City))) entity.City = City;
            if (ShouldMapTo(nameof(State))) entity.State = State;
            if (ShouldMapTo(nameof(Zip))) entity.Zip = Zip;
            if (ShouldMapTo(nameof(Country))) entity.Country = Country;
            if (ShouldMapTo(nameof(DateOfBirth))) entity.DateOfBirth = DateOfBirth;
            if (ShouldMapTo(nameof(EthnicityId))) entity.EthnicityId = EthnicityId;
            if (ShouldMapTo(nameof(CountryOfOrigin))) entity.CountryOfOrigin = CountryOfOrigin;
            if (ShouldMapTo(nameof(CityOfOrigin))) entity.CityOfOrigin = CityOfOrigin;
            if (ShouldMapTo(nameof(GenderId))) entity.GenderId = GenderId;
            if (ShouldMapTo(nameof(PointPersonId))) entity.PointPersonId = PointPersonId;
            if (ShouldMapTo(nameof(Notes))) entity.Notes = Notes;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Person MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Models.Person()
            {
                RegionId = RegionId,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(UserId))) entity.UserId = UserId;
            if (ShouldMapTo(nameof(SexAssignedAtBirth))) entity.SexAssignedAtBirth = (SexAssignedAtBirth ?? entity.SexAssignedAtBirth);
            if (ShouldMapTo(nameof(FirstName))) entity.FirstName = FirstName;
            if (ShouldMapTo(nameof(LastName))) entity.LastName = LastName;
            if (ShouldMapTo(nameof(Email))) entity.Email = Email;
            if (ShouldMapTo(nameof(Phone))) entity.Phone = Phone;
            if (ShouldMapTo(nameof(StreetAddress))) entity.StreetAddress = StreetAddress;
            if (ShouldMapTo(nameof(City))) entity.City = City;
            if (ShouldMapTo(nameof(State))) entity.State = State;
            if (ShouldMapTo(nameof(Zip))) entity.Zip = Zip;
            if (ShouldMapTo(nameof(Country))) entity.Country = Country;
            if (ShouldMapTo(nameof(DateOfBirth))) entity.DateOfBirth = DateOfBirth;
            if (ShouldMapTo(nameof(EthnicityId))) entity.EthnicityId = EthnicityId;
            if (ShouldMapTo(nameof(CountryOfOrigin))) entity.CountryOfOrigin = CountryOfOrigin;
            if (ShouldMapTo(nameof(CityOfOrigin))) entity.CityOfOrigin = CityOfOrigin;
            if (ShouldMapTo(nameof(GenderId))) entity.GenderId = GenderId;
            if (ShouldMapTo(nameof(PointPersonId))) entity.PointPersonId = PointPersonId;
            if (ShouldMapTo(nameof(Notes))) entity.Notes = Notes;

            return entity;
        }
    }

    public partial class PersonResponse : GeneratedResponseDto<PeopleCare.Data.Models.Person>
    {
        public PersonResponse() { }

        public string PersonId { get; set; }
        public string RegionId { get; set; }
        public string UserId { get; set; }
        public PeopleCare.Data.Models.Person.Sex? SexAssignedAtBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public System.DateOnly? DateOfBirth { get; set; }
        public int? EthnicityId { get; set; }
        public string CountryOfOrigin { get; set; }
        public string CityOfOrigin { get; set; }
        public string GenderId { get; set; }
        public string PointPersonId { get; set; }
        public string Notes { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.RegionResponse Region { get; set; }
        public PeopleCare.Web.Models.UserResponse User { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.RegionResponse> RegionsAvailable { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.PersonPersonTypeResponse> PersonTypes { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.EncounterResponse> Encounters { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.DonationResponse> Donations { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.DisbursementResponse> Disbursements { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.RelationshipResponse> Relationships { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.PersonTagResponse> Tags { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.DocumentResponse> Documents { get; set; }
        public PeopleCare.Web.Models.EthnicityResponse Ethnicity { get; set; }
        public PeopleCare.Web.Models.GenderResponse Gender { get; set; }
        public PeopleCare.Web.Models.PersonResponse PointPerson { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Person obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PersonId = obj.PersonId;
            this.RegionId = obj.RegionId;
            this.UserId = obj.UserId;
            this.SexAssignedAtBirth = obj.SexAssignedAtBirth;
            this.FirstName = obj.FirstName;
            this.LastName = obj.LastName;
            this.Email = obj.Email;
            this.Phone = obj.Phone;
            this.StreetAddress = obj.StreetAddress;
            this.City = obj.City;
            this.State = obj.State;
            this.Zip = obj.Zip;
            this.Country = obj.Country;
            this.DateOfBirth = obj.DateOfBirth;
            this.EthnicityId = obj.EthnicityId;
            this.CountryOfOrigin = obj.CountryOfOrigin;
            this.CityOfOrigin = obj.CityOfOrigin;
            this.GenderId = obj.GenderId;
            this.PointPersonId = obj.PointPersonId;
            this.Notes = obj.Notes;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Region)] != null)
                this.Region = obj.Region.MapToDto<PeopleCare.Data.Models.Region, RegionResponse>(context, tree?[nameof(this.Region)]);

            if (tree == null || tree[nameof(this.User)] != null)
                this.User = obj.User.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.User)]);

            var propValRegionsAvailable = obj.RegionsAvailable;
            if (propValRegionsAvailable != null && (tree == null || tree[nameof(this.RegionsAvailable)] != null))
            {
                this.RegionsAvailable = propValRegionsAvailable
                    .OrderBy(f => f.Name)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Region, RegionResponse>(context, tree?[nameof(this.RegionsAvailable)])).ToList();
            }
            else if (propValRegionsAvailable == null && tree?[nameof(this.RegionsAvailable)] != null)
            {
                this.RegionsAvailable = new RegionResponse[0];
            }

            var propValPersonTypes = obj.PersonTypes;
            if (propValPersonTypes != null && (tree == null || tree[nameof(this.PersonTypes)] != null))
            {
                this.PersonTypes = propValPersonTypes
                    .OrderBy(f => f.PersonPersonTypeId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.PersonPersonType, PersonPersonTypeResponse>(context, tree?[nameof(this.PersonTypes)])).ToList();
            }
            else if (propValPersonTypes == null && tree?[nameof(this.PersonTypes)] != null)
            {
                this.PersonTypes = new PersonPersonTypeResponse[0];
            }

            var propValEncounters = obj.Encounters;
            if (propValEncounters != null && (tree == null || tree[nameof(this.Encounters)] != null))
            {
                this.Encounters = propValEncounters
                    .OrderBy(f => f.EncounterId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Encounter, EncounterResponse>(context, tree?[nameof(this.Encounters)])).ToList();
            }
            else if (propValEncounters == null && tree?[nameof(this.Encounters)] != null)
            {
                this.Encounters = new EncounterResponse[0];
            }

            var propValDonations = obj.Donations;
            if (propValDonations != null && (tree == null || tree[nameof(this.Donations)] != null))
            {
                this.Donations = propValDonations
                    .OrderBy(f => f.DonationId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Donation, DonationResponse>(context, tree?[nameof(this.Donations)])).ToList();
            }
            else if (propValDonations == null && tree?[nameof(this.Donations)] != null)
            {
                this.Donations = new DonationResponse[0];
            }

            var propValDisbursements = obj.Disbursements;
            if (propValDisbursements != null && (tree == null || tree[nameof(this.Disbursements)] != null))
            {
                this.Disbursements = propValDisbursements
                    .OrderBy(f => f.DisbursementId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Disbursement, DisbursementResponse>(context, tree?[nameof(this.Disbursements)])).ToList();
            }
            else if (propValDisbursements == null && tree?[nameof(this.Disbursements)] != null)
            {
                this.Disbursements = new DisbursementResponse[0];
            }

            var propValRelationships = obj.Relationships;
            if (propValRelationships != null && (tree == null || tree[nameof(this.Relationships)] != null))
            {
                this.Relationships = propValRelationships
                    .OrderBy(f => f.RelationshipId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Relationship, RelationshipResponse>(context, tree?[nameof(this.Relationships)])).ToList();
            }
            else if (propValRelationships == null && tree?[nameof(this.Relationships)] != null)
            {
                this.Relationships = new RelationshipResponse[0];
            }

            var propValTags = obj.Tags;
            if (propValTags != null && (tree == null || tree[nameof(this.Tags)] != null))
            {
                this.Tags = propValTags
                    .OrderBy(f => f.PersonTagId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.PersonTag, PersonTagResponse>(context, tree?[nameof(this.Tags)])).ToList();
            }
            else if (propValTags == null && tree?[nameof(this.Tags)] != null)
            {
                this.Tags = new PersonTagResponse[0];
            }

            var propValDocuments = obj.Documents;
            if (propValDocuments != null && (tree == null || tree[nameof(this.Documents)] != null))
            {
                this.Documents = propValDocuments
                    .OrderBy(f => f.DocumentId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Document, DocumentResponse>(context, tree?[nameof(this.Documents)])).ToList();
            }
            else if (propValDocuments == null && tree?[nameof(this.Documents)] != null)
            {
                this.Documents = new DocumentResponse[0];
            }

            if (tree == null || tree[nameof(this.Ethnicity)] != null)
                this.Ethnicity = obj.Ethnicity.MapToDto<PeopleCare.Data.Models.Ethnicity, EthnicityResponse>(context, tree?[nameof(this.Ethnicity)]);

            if (tree == null || tree[nameof(this.Gender)] != null)
                this.Gender = obj.Gender.MapToDto<PeopleCare.Data.Models.Gender, GenderResponse>(context, tree?[nameof(this.Gender)]);

            if (tree == null || tree[nameof(this.PointPerson)] != null)
                this.PointPerson = obj.PointPerson.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.PointPerson)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
