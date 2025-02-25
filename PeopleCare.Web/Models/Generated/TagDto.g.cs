using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class TagParameter : GeneratedParameterDto<PeopleCare.Data.Models.Tag>
    {
        public TagParameter() { }

        private string _TagId;
        private string _Name;

        public string TagId
        {
            get => _TagId;
            set { _TagId = value; Changed(nameof(TagId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Tag entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(TagId))) entity.TagId = TagId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Tag MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Models.Tag()
            {
                Name = Name,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(TagId))) entity.TagId = TagId;

            return entity;
        }
    }

    public partial class TagResponse : GeneratedResponseDto<PeopleCare.Data.Models.Tag>
    {
        public TagResponse() { }

        public string TagId { get; set; }
        public string Name { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.PersonResponse> People { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Tag obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.TagId = obj.TagId;
            this.Name = obj.Name;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            var propValPeople = obj.People;
            if (propValPeople != null && (tree == null || tree[nameof(this.People)] != null))
            {
                this.People = propValPeople
                    .OrderBy(f => f.PersonId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.People)])).ToList();
            }
            else if (propValPeople == null && tree?[nameof(this.People)] != null)
            {
                this.People = new PersonResponse[0];
            }

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
