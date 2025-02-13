using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class DonationParameter : GeneratedParameterDto<PeopleCare.Data.Models.Donation>
    {
        public DonationParameter() { }

        private string _DonationId;
        private string _PersonId;
        private string _RegionId;
        private string _Description;
        private bool? _IsInKind;
        private decimal? _Value;
        private int? _Quantity;
        private System.DateOnly? _Date;

        public string DonationId
        {
            get => _DonationId;
            set { _DonationId = value; Changed(nameof(DonationId)); }
        }
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
        public string Description
        {
            get => _Description;
            set { _Description = value; Changed(nameof(Description)); }
        }
        public bool? IsInKind
        {
            get => _IsInKind;
            set { _IsInKind = value; Changed(nameof(IsInKind)); }
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
        public System.DateOnly? Date
        {
            get => _Date;
            set { _Date = value; Changed(nameof(Date)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Donation entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(DonationId))) entity.DonationId = DonationId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(RegionId))) entity.RegionId = RegionId;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(IsInKind))) entity.IsInKind = (IsInKind ?? entity.IsInKind);
            if (ShouldMapTo(nameof(Value))) entity.Value = (Value ?? entity.Value);
            if (ShouldMapTo(nameof(Quantity))) entity.Quantity = (Quantity ?? entity.Quantity);
            if (ShouldMapTo(nameof(Date))) entity.Date = (Date ?? entity.Date);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Donation MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.Donation();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class DonationResponse : GeneratedResponseDto<PeopleCare.Data.Models.Donation>
    {
        public DonationResponse() { }

        public string DonationId { get; set; }
        public string PersonId { get; set; }
        public string RegionId { get; set; }
        public string Description { get; set; }
        public bool? IsInKind { get; set; }
        public decimal? Value { get; set; }
        public int? Quantity { get; set; }
        public System.DateOnly? Date { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.RegionResponse Region { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.DisbursementResponse> Disbursements { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Donation obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.DonationId = obj.DonationId;
            this.PersonId = obj.PersonId;
            this.RegionId = obj.RegionId;
            this.Description = obj.Description;
            this.IsInKind = obj.IsInKind;
            this.Value = obj.Value;
            this.Quantity = obj.Quantity;
            this.Date = obj.Date;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

            if (tree == null || tree[nameof(this.Region)] != null)
                this.Region = obj.Region.MapToDto<PeopleCare.Data.Models.Region, RegionResponse>(context, tree?[nameof(this.Region)]);

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

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
