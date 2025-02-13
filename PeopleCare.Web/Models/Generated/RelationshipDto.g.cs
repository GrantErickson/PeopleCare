using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class RelationshipParameter : GeneratedParameterDto<PeopleCare.Data.Models.Relationship>
    {
        public RelationshipParameter() { }

        private string _RelationshipId;
        private string _PersonId;
        private string _RelatedPersonId;
        private string _RelationshipTypeId;
        private System.DateOnly? _StartDate;
        private System.DateOnly? _EndDate;
        private bool? _IsActive;
        private string _Note;
        private string _OppositeRelationshipId;

        public string RelationshipId
        {
            get => _RelationshipId;
            set { _RelationshipId = value; Changed(nameof(RelationshipId)); }
        }
        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string RelatedPersonId
        {
            get => _RelatedPersonId;
            set { _RelatedPersonId = value; Changed(nameof(RelatedPersonId)); }
        }
        public string RelationshipTypeId
        {
            get => _RelationshipTypeId;
            set { _RelationshipTypeId = value; Changed(nameof(RelationshipTypeId)); }
        }
        public System.DateOnly? StartDate
        {
            get => _StartDate;
            set { _StartDate = value; Changed(nameof(StartDate)); }
        }
        public System.DateOnly? EndDate
        {
            get => _EndDate;
            set { _EndDate = value; Changed(nameof(EndDate)); }
        }
        public bool? IsActive
        {
            get => _IsActive;
            set { _IsActive = value; Changed(nameof(IsActive)); }
        }
        public string Note
        {
            get => _Note;
            set { _Note = value; Changed(nameof(Note)); }
        }
        public string OppositeRelationshipId
        {
            get => _OppositeRelationshipId;
            set { _OppositeRelationshipId = value; Changed(nameof(OppositeRelationshipId)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Relationship entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(RelationshipId))) entity.RelationshipId = RelationshipId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(RelatedPersonId))) entity.RelatedPersonId = RelatedPersonId;
            if (ShouldMapTo(nameof(RelationshipTypeId))) entity.RelationshipTypeId = RelationshipTypeId;
            if (ShouldMapTo(nameof(StartDate))) entity.StartDate = StartDate;
            if (ShouldMapTo(nameof(EndDate))) entity.EndDate = EndDate;
            if (ShouldMapTo(nameof(IsActive))) entity.IsActive = (IsActive ?? entity.IsActive);
            if (ShouldMapTo(nameof(Note))) entity.Note = Note;
            if (ShouldMapTo(nameof(OppositeRelationshipId))) entity.OppositeRelationshipId = OppositeRelationshipId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Relationship MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.Relationship();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class RelationshipResponse : GeneratedResponseDto<PeopleCare.Data.Models.Relationship>
    {
        public RelationshipResponse() { }

        public string RelationshipId { get; set; }
        public string PersonId { get; set; }
        public string RelatedPersonId { get; set; }
        public string RelationshipTypeId { get; set; }
        public System.DateOnly? StartDate { get; set; }
        public System.DateOnly? EndDate { get; set; }
        public bool? IsActive { get; set; }
        public string Note { get; set; }
        public string OppositeRelationshipId { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.PersonResponse RelatedPerson { get; set; }
        public PeopleCare.Web.Models.RelationshipTypeResponse RelationshipType { get; set; }
        public PeopleCare.Web.Models.RelationshipResponse OppositeRelationship { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Relationship obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.RelationshipId = obj.RelationshipId;
            this.PersonId = obj.PersonId;
            this.RelatedPersonId = obj.RelatedPersonId;
            this.RelationshipTypeId = obj.RelationshipTypeId;
            this.StartDate = obj.StartDate;
            this.EndDate = obj.EndDate;
            this.IsActive = obj.IsActive;
            this.Note = obj.Note;
            this.OppositeRelationshipId = obj.OppositeRelationshipId;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

            if (tree == null || tree[nameof(this.RelatedPerson)] != null)
                this.RelatedPerson = obj.RelatedPerson.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.RelatedPerson)]);

            if (tree == null || tree[nameof(this.RelationshipType)] != null)
                this.RelationshipType = obj.RelationshipType.MapToDto<PeopleCare.Data.Models.RelationshipType, RelationshipTypeResponse>(context, tree?[nameof(this.RelationshipType)]);

            if (tree == null || tree[nameof(this.OppositeRelationship)] != null)
                this.OppositeRelationship = obj.OppositeRelationship.MapToDto<PeopleCare.Data.Models.Relationship, RelationshipResponse>(context, tree?[nameof(this.OppositeRelationship)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
