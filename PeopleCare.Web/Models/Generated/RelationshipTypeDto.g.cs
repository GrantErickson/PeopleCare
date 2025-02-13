using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class RelationshipTypeParameter : GeneratedParameterDto<PeopleCare.Data.Models.RelationshipType>
    {
        public RelationshipTypeParameter() { }

        private string _RelationshipTypeId;
        private string _Name;
        private string _OppositeRelationshipTypeId;
        private string _EntityName;
        private string _RelatedEntityName;

        public string RelationshipTypeId
        {
            get => _RelationshipTypeId;
            set { _RelationshipTypeId = value; Changed(nameof(RelationshipTypeId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public string OppositeRelationshipTypeId
        {
            get => _OppositeRelationshipTypeId;
            set { _OppositeRelationshipTypeId = value; Changed(nameof(OppositeRelationshipTypeId)); }
        }
        public string EntityName
        {
            get => _EntityName;
            set { _EntityName = value; Changed(nameof(EntityName)); }
        }
        public string RelatedEntityName
        {
            get => _RelatedEntityName;
            set { _RelatedEntityName = value; Changed(nameof(RelatedEntityName)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.RelationshipType entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(RelationshipTypeId))) entity.RelationshipTypeId = RelationshipTypeId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(OppositeRelationshipTypeId))) entity.OppositeRelationshipTypeId = OppositeRelationshipTypeId;
            if (ShouldMapTo(nameof(EntityName))) entity.EntityName = EntityName;
            if (ShouldMapTo(nameof(RelatedEntityName))) entity.RelatedEntityName = RelatedEntityName;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.RelationshipType MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Models.RelationshipType()
            {
                EntityName = EntityName,
                RelatedEntityName = RelatedEntityName,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(RelationshipTypeId))) entity.RelationshipTypeId = RelationshipTypeId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(OppositeRelationshipTypeId))) entity.OppositeRelationshipTypeId = OppositeRelationshipTypeId;

            return entity;
        }
    }

    public partial class RelationshipTypeResponse : GeneratedResponseDto<PeopleCare.Data.Models.RelationshipType>
    {
        public RelationshipTypeResponse() { }

        public string RelationshipTypeId { get; set; }
        public string Name { get; set; }
        public string OppositeRelationshipTypeId { get; set; }
        public string EntityName { get; set; }
        public string RelatedEntityName { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.RelationshipTypeResponse OppositeRelationshipType { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.RelationshipType obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.RelationshipTypeId = obj.RelationshipTypeId;
            this.Name = obj.Name;
            this.OppositeRelationshipTypeId = obj.OppositeRelationshipTypeId;
            this.EntityName = obj.EntityName;
            this.RelatedEntityName = obj.RelatedEntityName;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.OppositeRelationshipType)] != null)
                this.OppositeRelationshipType = obj.OppositeRelationshipType.MapToDto<PeopleCare.Data.Models.RelationshipType, RelationshipTypeResponse>(context, tree?[nameof(this.OppositeRelationshipType)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
