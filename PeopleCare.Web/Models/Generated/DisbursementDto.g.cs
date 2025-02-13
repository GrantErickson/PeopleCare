using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class DisbursementParameter : GeneratedParameterDto<PeopleCare.Data.Models.Disbursement>
    {
        public DisbursementParameter() { }

        private string _DisbursementId;
        private string _PersonId;
        private string _DonationId;
        private string _RegionId;
        private string _Description;
        private System.DateOnly? _Date;
        private decimal? _Value;
        private int? _Quantity;

        public string DisbursementId
        {
            get => _DisbursementId;
            set { _DisbursementId = value; Changed(nameof(DisbursementId)); }
        }
        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string DonationId
        {
            get => _DonationId;
            set { _DonationId = value; Changed(nameof(DonationId)); }
        }
        public string RegionId
        {
            get => _RegionId;
            set { _RegionId = value; Changed(nameof(RegionId)); }
        }
        public string Description
        {
            get => _Description;
            set { _Description = value; Changed(nameof(Description)); }
        }
        public System.DateOnly? Date
        {
            get => _Date;
            set { _Date = value; Changed(nameof(Date)); }
        }
        public decimal? Value
        {
            get => _Value;
            set { _Value = value; Changed(nameof(Value)); }
        }
        public int? Quantity
        {
            get => _Quantity;
            set { _Quantity = value; Changed(nameof(Quantity)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Disbursement entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(DisbursementId))) entity.DisbursementId = DisbursementId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(DonationId))) entity.DonationId = DonationId;
            if (ShouldMapTo(nameof(RegionId))) entity.RegionId = RegionId;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(Date))) entity.Date = (Date ?? entity.Date);
            if (ShouldMapTo(nameof(Value))) entity.Value = (Value ?? entity.Value);
            if (ShouldMapTo(nameof(Quantity))) entity.Quantity = (Quantity ?? entity.Quantity);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Disbursement MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.Disbursement();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class DisbursementResponse : GeneratedResponseDto<PeopleCare.Data.Models.Disbursement>
    {
        public DisbursementResponse() { }

        public string DisbursementId { get; set; }
        public string PersonId { get; set; }
        public string DonationId { get; set; }
        public string RegionId { get; set; }
        public string Description { get; set; }
        public System.DateOnly? Date { get; set; }
        public decimal? Value { get; set; }
        public int? Quantity { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.DonationResponse Donation { get; set; }
        public PeopleCare.Web.Models.RegionResponse Region { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Disbursement obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.DisbursementId = obj.DisbursementId;
            this.PersonId = obj.PersonId;
            this.DonationId = obj.DonationId;
            this.RegionId = obj.RegionId;
            this.Description = obj.Description;
            this.Date = obj.Date;
            this.Value = obj.Value;
            this.Quantity = obj.Quantity;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

            if (tree == null || tree[nameof(this.Donation)] != null)
                this.Donation = obj.Donation.MapToDto<PeopleCare.Data.Models.Donation, DonationResponse>(context, tree?[nameof(this.Donation)]);

            if (tree == null || tree[nameof(this.Region)] != null)
                this.Region = obj.Region.MapToDto<PeopleCare.Data.Models.Region, RegionResponse>(context, tree?[nameof(this.Region)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
