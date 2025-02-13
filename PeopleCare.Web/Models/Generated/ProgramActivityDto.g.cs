using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class ProgramActivityParameter : GeneratedParameterDto<PeopleCare.Data.Models.ProgramActivity>
    {
        public ProgramActivityParameter() { }

        private string _ProgramActivityId;
        private string _ProgramId;
        private string _ActivityId;

        public string ProgramActivityId
        {
            get => _ProgramActivityId;
            set { _ProgramActivityId = value; Changed(nameof(ProgramActivityId)); }
        }
        public string ProgramId
        {
            get => _ProgramId;
            set { _ProgramId = value; Changed(nameof(ProgramId)); }
        }
        public string ActivityId
        {
            get => _ActivityId;
            set { _ActivityId = value; Changed(nameof(ActivityId)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.ProgramActivity entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(ProgramActivityId))) entity.ProgramActivityId = ProgramActivityId;
            if (ShouldMapTo(nameof(ProgramId))) entity.ProgramId = ProgramId;
            if (ShouldMapTo(nameof(ActivityId))) entity.ActivityId = ActivityId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.ProgramActivity MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.ProgramActivity();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class ProgramActivityResponse : GeneratedResponseDto<PeopleCare.Data.Models.ProgramActivity>
    {
        public ProgramActivityResponse() { }

        public string ProgramActivityId { get; set; }
        public string ProgramId { get; set; }
        public string ActivityId { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.ProgramResponse Program { get; set; }
        public PeopleCare.Web.Models.ActivityResponse Activity { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.ProgramActivity obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.ProgramActivityId = obj.ProgramActivityId;
            this.ProgramId = obj.ProgramId;
            this.ActivityId = obj.ActivityId;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Program)] != null)
                this.Program = obj.Program.MapToDto<PeopleCare.Data.Models.Program, ProgramResponse>(context, tree?[nameof(this.Program)]);

            if (tree == null || tree[nameof(this.Activity)] != null)
                this.Activity = obj.Activity.MapToDto<PeopleCare.Data.Models.Activity, ActivityResponse>(context, tree?[nameof(this.Activity)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
