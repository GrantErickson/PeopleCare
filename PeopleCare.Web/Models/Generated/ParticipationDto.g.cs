using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class ParticipationParameter : GeneratedParameterDto<PeopleCare.Data.Models.Participation>
    {
        public ParticipationParameter() { }

        private string _ParticipationId;
        private string _PersonId;
        private string _ActivityId;
        private string _ProgramId;
        private string _FundingSourceId;
        private bool? _IsRegistered;
        private bool? _IsAttended;
        private string _FormId;

        public string ParticipationId
        {
            get => _ParticipationId;
            set { _ParticipationId = value; Changed(nameof(ParticipationId)); }
        }
        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string ActivityId
        {
            get => _ActivityId;
            set { _ActivityId = value; Changed(nameof(ActivityId)); }
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
        public bool? IsRegistered
        {
            get => _IsRegistered;
            set { _IsRegistered = value; Changed(nameof(IsRegistered)); }
        }
        public bool? IsAttended
        {
            get => _IsAttended;
            set { _IsAttended = value; Changed(nameof(IsAttended)); }
        }
        public string FormId
        {
            get => _FormId;
            set { _FormId = value; Changed(nameof(FormId)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Participation entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(ParticipationId))) entity.ParticipationId = ParticipationId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(ActivityId))) entity.ActivityId = ActivityId;
            if (ShouldMapTo(nameof(ProgramId))) entity.ProgramId = ProgramId;
            if (ShouldMapTo(nameof(FundingSourceId))) entity.FundingSourceId = FundingSourceId;
            if (ShouldMapTo(nameof(IsRegistered))) entity.IsRegistered = (IsRegistered ?? entity.IsRegistered);
            if (ShouldMapTo(nameof(IsAttended))) entity.IsAttended = (IsAttended ?? entity.IsAttended);
            if (ShouldMapTo(nameof(FormId))) entity.FormId = FormId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Participation MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.Participation();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class ParticipationResponse : GeneratedResponseDto<PeopleCare.Data.Models.Participation>
    {
        public ParticipationResponse() { }

        public string ParticipationId { get; set; }
        public string PersonId { get; set; }
        public string ActivityId { get; set; }
        public string ProgramId { get; set; }
        public string FundingSourceId { get; set; }
        public bool? IsRegistered { get; set; }
        public bool? IsAttended { get; set; }
        public string FormId { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.ActivityResponse Activity { get; set; }
        public PeopleCare.Web.Models.ProgramResponse Program { get; set; }
        public PeopleCare.Web.Models.FundingSourceResponse FundingSource { get; set; }
        public PeopleCare.Web.Models.FormResponse Form { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Participation obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.ParticipationId = obj.ParticipationId;
            this.PersonId = obj.PersonId;
            this.ActivityId = obj.ActivityId;
            this.ProgramId = obj.ProgramId;
            this.FundingSourceId = obj.FundingSourceId;
            this.IsRegistered = obj.IsRegistered;
            this.IsAttended = obj.IsAttended;
            this.FormId = obj.FormId;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

            if (tree == null || tree[nameof(this.Activity)] != null)
                this.Activity = obj.Activity.MapToDto<PeopleCare.Data.Models.Activity, ActivityResponse>(context, tree?[nameof(this.Activity)]);

            if (tree == null || tree[nameof(this.Program)] != null)
                this.Program = obj.Program.MapToDto<PeopleCare.Data.Models.Program, ProgramResponse>(context, tree?[nameof(this.Program)]);

            if (tree == null || tree[nameof(this.FundingSource)] != null)
                this.FundingSource = obj.FundingSource.MapToDto<PeopleCare.Data.Models.FundingSource, FundingSourceResponse>(context, tree?[nameof(this.FundingSource)]);

            if (tree == null || tree[nameof(this.Form)] != null)
                this.Form = obj.Form.MapToDto<PeopleCare.Data.Models.Forms.Form, FormResponse>(context, tree?[nameof(this.Form)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
