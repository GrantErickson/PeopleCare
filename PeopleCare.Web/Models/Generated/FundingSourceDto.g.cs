using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class FundingSourceParameter : GeneratedParameterDto<PeopleCare.Data.Models.FundingSource>
    {
        public FundingSourceParameter() { }

        private string _FundingSourceId;
        private string _Name;

        public string FundingSourceId
        {
            get => _FundingSourceId;
            set { _FundingSourceId = value; Changed(nameof(FundingSourceId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.FundingSource entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(FundingSourceId))) entity.FundingSourceId = FundingSourceId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.FundingSource MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.FundingSource();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class FundingSourceResponse : GeneratedResponseDto<PeopleCare.Data.Models.FundingSource>
    {
        public FundingSourceResponse() { }

        public string FundingSourceId { get; set; }
        public string Name { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.ProgramFundingSourceResponse> ProgramFundingSources { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.FundingSource obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.FundingSourceId = obj.FundingSourceId;
            this.Name = obj.Name;
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

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
