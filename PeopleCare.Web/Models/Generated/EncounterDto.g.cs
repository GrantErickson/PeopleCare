using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class EncounterParameter : GeneratedParameterDto<PeopleCare.Data.Models.Encounter>
    {
        public EncounterParameter() { }

        private string _EncounterId;
        private string _PersonId;
        private string _ContactedById;
        private string _RegionId;
        private string _EncounterTypeId;
        private string _Notes;
        private string _Location;
        private System.DateTime? _Date;
        private int? _DurationInMinutes;

        public string EncounterId
        {
            get => _EncounterId;
            set { _EncounterId = value; Changed(nameof(EncounterId)); }
        }
        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string ContactedById
        {
            get => _ContactedById;
            set { _ContactedById = value; Changed(nameof(ContactedById)); }
        }
        public string RegionId
        {
            get => _RegionId;
            set { _RegionId = value; Changed(nameof(RegionId)); }
        }
        public string EncounterTypeId
        {
            get => _EncounterTypeId;
            set { _EncounterTypeId = value; Changed(nameof(EncounterTypeId)); }
        }
        public string Notes
        {
            get => _Notes;
            set { _Notes = value; Changed(nameof(Notes)); }
        }
        public string Location
        {
            get => _Location;
            set { _Location = value; Changed(nameof(Location)); }
        }
        public System.DateTime? Date
        {
            get => _Date;
            set { _Date = value; Changed(nameof(Date)); }
        }
        public int? DurationInMinutes
        {
            get => _DurationInMinutes;
            set { _DurationInMinutes = value; Changed(nameof(DurationInMinutes)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Encounter entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(EncounterId))) entity.EncounterId = EncounterId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(ContactedById))) entity.ContactedById = ContactedById;
            if (ShouldMapTo(nameof(RegionId))) entity.RegionId = RegionId;
            if (ShouldMapTo(nameof(EncounterTypeId))) entity.EncounterTypeId = EncounterTypeId;
            if (ShouldMapTo(nameof(Notes))) entity.Notes = Notes;
            if (ShouldMapTo(nameof(Location))) entity.Location = Location;
            if (ShouldMapTo(nameof(Date))) entity.Date = Date;
            if (ShouldMapTo(nameof(DurationInMinutes))) entity.DurationInMinutes = DurationInMinutes;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Encounter MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.Encounter();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class EncounterResponse : GeneratedResponseDto<PeopleCare.Data.Models.Encounter>
    {
        public EncounterResponse() { }

        public string EncounterId { get; set; }
        public string PersonId { get; set; }
        public string ContactedById { get; set; }
        public string RegionId { get; set; }
        public string EncounterTypeId { get; set; }
        public string Notes { get; set; }
        public string Location { get; set; }
        public System.DateTime? Date { get; set; }
        public int? DurationInMinutes { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.PersonResponse ContactedBy { get; set; }
        public PeopleCare.Web.Models.RegionResponse Region { get; set; }
        public PeopleCare.Web.Models.EncounterTypeResponse EncounterType { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Encounter obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.EncounterId = obj.EncounterId;
            this.PersonId = obj.PersonId;
            this.ContactedById = obj.ContactedById;
            this.RegionId = obj.RegionId;
            this.EncounterTypeId = obj.EncounterTypeId;
            this.Notes = obj.Notes;
            this.Location = obj.Location;
            this.Date = obj.Date;
            this.DurationInMinutes = obj.DurationInMinutes;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

            if (tree == null || tree[nameof(this.ContactedBy)] != null)
                this.ContactedBy = obj.ContactedBy.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.ContactedBy)]);

            if (tree == null || tree[nameof(this.Region)] != null)
                this.Region = obj.Region.MapToDto<PeopleCare.Data.Models.Region, RegionResponse>(context, tree?[nameof(this.Region)]);


            this.EncounterType = obj.EncounterType.MapToDto<PeopleCare.Data.Models.EncounterType, EncounterTypeResponse>(context, tree?[nameof(this.EncounterType)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
