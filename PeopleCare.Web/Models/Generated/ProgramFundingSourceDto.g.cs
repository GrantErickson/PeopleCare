using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class ProgramFundingSourceParameter : GeneratedParameterDto<PeopleCare.Data.Models.ProgramFundingSource>
    {
        public ProgramFundingSourceParameter() { }

        private string _ProgramFundingSourceId;
        private string _ProgramId;
        private string _FundingSourceId;

        public string ProgramFundingSourceId
        {
            get => _ProgramFundingSourceId;
            set { _ProgramFundingSourceId = value; Changed(nameof(ProgramFundingSourceId)); }
        }
        public string ProgramId
        {
            get => _ProgramId;
            set { _ProgramId = value; Changed(nameof(ProgramId)); }
        }
        public string FundingSourceId
        {
            get => _FundingSourceId;
            set { _FundingSourceId = value; Changed(nameof(FundingSourceId)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.ProgramFundingSource entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(ProgramFundingSourceId))) entity.ProgramFundingSourceId = ProgramFundingSourceId;
            if (ShouldMapTo(nameof(ProgramId))) entity.ProgramId = ProgramId;
            if (ShouldMapTo(nameof(FundingSourceId))) entity.FundingSourceId = FundingSourceId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.ProgramFundingSource MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.ProgramFundingSource();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class ProgramFundingSourceResponse : GeneratedResponseDto<PeopleCare.Data.Models.ProgramFundingSource>
    {
        public ProgramFundingSourceResponse() { }

        public string ProgramFundingSourceId { get; set; }
        public string ProgramId { get; set; }
        public string FundingSourceId { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.ProgramResponse Program { get; set; }
        public PeopleCare.Web.Models.FundingSourceResponse FundingSource { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.ProgramFundingSource obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.ProgramFundingSourceId = obj.ProgramFundingSourceId;
            this.ProgramId = obj.ProgramId;
            this.FundingSourceId = obj.FundingSourceId;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Program)] != null)
                this.Program = obj.Program.MapToDto<PeopleCare.Data.Models.Program, ProgramResponse>(context, tree?[nameof(this.Program)]);

            if (tree == null || tree[nameof(this.FundingSource)] != null)
                this.FundingSource = obj.FundingSource.MapToDto<PeopleCare.Data.Models.FundingSource, FundingSourceResponse>(context, tree?[nameof(this.FundingSource)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
