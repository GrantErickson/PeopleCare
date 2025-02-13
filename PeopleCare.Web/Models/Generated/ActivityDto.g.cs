using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class ActivityParameter : GeneratedParameterDto<PeopleCare.Data.Models.Activity>
    {
        public ActivityParameter() { }

        private string _ActivityId;
        private string _Name;
        private string _Description;
        private System.DateTime? _Date;
        private int? _DurationInMinutes;

        public string ActivityId
        {
            get => _ActivityId;
            set { _ActivityId = value; Changed(nameof(ActivityId)); }
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
        public override void MapTo(PeopleCare.Data.Models.Activity entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(ActivityId))) entity.ActivityId = ActivityId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(Date))) entity.Date = Date;
            if (ShouldMapTo(nameof(DurationInMinutes))) entity.DurationInMinutes = (DurationInMinutes ?? entity.DurationInMinutes);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Activity MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Models.Activity()
            {
                Name = Name,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(ActivityId))) entity.ActivityId = ActivityId;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(Date))) entity.Date = Date;
            if (ShouldMapTo(nameof(DurationInMinutes))) entity.DurationInMinutes = (DurationInMinutes ?? entity.DurationInMinutes);

            return entity;
        }
    }

    public partial class ActivityResponse : GeneratedResponseDto<PeopleCare.Data.Models.Activity>
    {
        public ActivityResponse() { }

        public string ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime? Date { get; set; }
        public int? DurationInMinutes { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.ProgramResponse> Programs { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.ParticipationResponse> Participants { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Activity obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.ActivityId = obj.ActivityId;
            this.Name = obj.Name;
            this.Description = obj.Description;
            this.Date = obj.Date;
            this.DurationInMinutes = obj.DurationInMinutes;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            var propValPrograms = obj.Programs;
            if (propValPrograms != null && (tree == null || tree[nameof(this.Programs)] != null))
            {
                this.Programs = propValPrograms
                    .OrderBy(f => f.Name)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Program, ProgramResponse>(context, tree?[nameof(this.Programs)])).ToList();
            }
            else if (propValPrograms == null && tree?[nameof(this.Programs)] != null)
            {
                this.Programs = new ProgramResponse[0];
            }

            var propValParticipants = obj.Participants;
            if (propValParticipants != null)
            {
                this.Participants = propValParticipants
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Participation, ParticipationResponse>(context, tree?[nameof(this.Participants)])).ToList();
            }

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
