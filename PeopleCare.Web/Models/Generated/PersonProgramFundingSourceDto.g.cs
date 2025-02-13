using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class PersonProgramFundingSourceParameter : GeneratedParameterDto<PeopleCare.Data.Models.PersonProgramFundingSource>
    {
        public PersonProgramFundingSourceParameter() { }

        private string _PersonProgramFundingSourceId;
        private string _PersonId;
        private string _ProgramId;
        private string _FundingSourceId;
        private PeopleCare.Data.Models.PersonProgramFundingSource.ProgramState? _State;
        private System.DateOnly? _DateEnrolled;

        public string PersonProgramFundingSourceId
        {
            get => _PersonProgramFundingSourceId;
            set { _PersonProgramFundingSourceId = value; Changed(nameof(PersonProgramFundingSourceId)); }
        }
        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
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
        public PeopleCare.Data.Models.PersonProgramFundingSource.ProgramState? State
        {
            get => _State;
            set { _State = value; Changed(nameof(State)); }
        }
        public System.DateOnly? DateEnrolled
        {
            get => _DateEnrolled;
            set { _DateEnrolled = value; Changed(nameof(DateEnrolled)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.PersonProgramFundingSource entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PersonProgramFundingSourceId))) entity.PersonProgramFundingSourceId = PersonProgramFundingSourceId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(ProgramId))) entity.ProgramId = ProgramId;
            if (ShouldMapTo(nameof(FundingSourceId))) entity.FundingSourceId = FundingSourceId;
            if (ShouldMapTo(nameof(State))) entity.State = (State ?? entity.State);
            if (ShouldMapTo(nameof(DateEnrolled))) entity.DateEnrolled = (DateEnrolled ?? entity.DateEnrolled);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.PersonProgramFundingSource MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.PersonProgramFundingSource();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class PersonProgramFundingSourceResponse : GeneratedResponseDto<PeopleCare.Data.Models.PersonProgramFundingSource>
    {
        public PersonProgramFundingSourceResponse() { }

        public string PersonProgramFundingSourceId { get; set; }
        public string PersonId { get; set; }
        public string ProgramId { get; set; }
        public string FundingSourceId { get; set; }
        public PeopleCare.Data.Models.PersonProgramFundingSource.ProgramState? State { get; set; }
        public System.DateOnly? DateEnrolled { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.ProgramResponse Program { get; set; }
        public PeopleCare.Web.Models.FundingSourceResponse FundingSource { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.PersonProgramFundingSource obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PersonProgramFundingSourceId = obj.PersonProgramFundingSourceId;
            this.PersonId = obj.PersonId;
            this.ProgramId = obj.ProgramId;
            this.FundingSourceId = obj.FundingSourceId;
            this.State = obj.State;
            this.DateEnrolled = obj.DateEnrolled;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

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
