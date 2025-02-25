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
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.ProgramFundingSourceResponse> ProgramFundingSources { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.ProgramActivityResponse> ProgramActivities { get; set; }
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
            var propValProgramFundingSources = obj.ProgramFundingSources;
            if (propValProgramFundingSources != null && (tree == null || tree[nameof(this.ProgramFundingSources)] != null))
            {
                this.ProgramFundingSources = propValProgramFundingSources
                    .OrderBy(f => f.ProgramFundingSourceId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.ProgramFundingSource, ProgramFundingSourceResponse>(context, tree?[nameof(this.ProgramFundingSources)])).ToList();
            }
            else if (propValProgramFundingSources == null && tree?[nameof(this.ProgramFundingSources)] != null)
            {
                this.ProgramFundingSources = new ProgramFundingSourceResponse[0];
            }

            var propValProgramActivities = obj.ProgramActivities;
            if (propValProgramActivities != null && (tree == null || tree[nameof(this.ProgramActivities)] != null))
            {
                this.ProgramActivities = propValProgramActivities
                    .OrderBy(f => f.ProgramActivityId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.ProgramActivity, ProgramActivityResponse>(context, tree?[nameof(this.ProgramActivities)])).ToList();
            }
            else if (propValProgramActivities == null && tree?[nameof(this.ProgramActivities)] != null)
            {
                this.ProgramActivities = new ProgramActivityResponse[0];
            }

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
