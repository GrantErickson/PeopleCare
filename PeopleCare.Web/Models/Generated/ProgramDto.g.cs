using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class ProgramParameter : GeneratedParameterDto<PeopleCare.Data.Models.Program>
    {
        public ProgramParameter() { }

        private string _ProgramId;
        private string _Name;
        private string _Description;

        public string ProgramId
        {
            get => _ProgramId;
            set { _ProgramId = value; Changed(nameof(ProgramId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public string Description
        {
            get => _Description;
            set { _Description = value; Changed(nameof(Description)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Program entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(ProgramId))) entity.ProgramId = ProgramId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Program MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.Program();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class ProgramResponse : GeneratedResponseDto<PeopleCare.Data.Models.Program>
    {
        public ProgramResponse() { }

        public string ProgramId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.FundingSourceResponse> FundingSources { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.ActivityResponse> Activities { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Program obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.ProgramId = obj.ProgramId;
            this.Name = obj.Name;
            this.Description = obj.Description;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            var propValFundingSources = obj.FundingSources;
            if (propValFundingSources != null && (tree == null || tree[nameof(this.FundingSources)] != null))
            {
                this.FundingSources = propValFundingSources
                    .OrderBy(f => f.Name)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.FundingSource, FundingSourceResponse>(context, tree?[nameof(this.FundingSources)])).ToList();
            }
            else if (propValFundingSources == null && tree?[nameof(this.FundingSources)] != null)
            {
                this.FundingSources = new FundingSourceResponse[0];
            }

            var propValActivities = obj.Activities;
            if (propValActivities != null && (tree == null || tree[nameof(this.Activities)] != null))
            {
                this.Activities = propValActivities
                    .OrderBy(f => f.Name)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Activity, ActivityResponse>(context, tree?[nameof(this.Activities)])).ToList();
            }
            else if (propValActivities == null && tree?[nameof(this.Activities)] != null)
            {
                this.Activities = new ActivityResponse[0];
            }

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
