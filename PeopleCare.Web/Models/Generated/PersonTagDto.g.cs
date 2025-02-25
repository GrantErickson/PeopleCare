using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class PersonTagParameter : GeneratedParameterDto<PeopleCare.Data.Models.PersonTag>
    {
        public PersonTagParameter() { }

        private string _PersonTagId;
        private string _PersonId;
        private string _TagId;

        public string PersonTagId
        {
            get => _PersonTagId;
            set { _PersonTagId = value; Changed(nameof(PersonTagId)); }
        }
        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string TagId
        {
            get => _TagId;
            set { _TagId = value; Changed(nameof(TagId)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.PersonTag entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PersonTagId))) entity.PersonTagId = PersonTagId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(TagId))) entity.TagId = TagId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.PersonTag MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.PersonTag();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class PersonTagResponse : GeneratedResponseDto<PeopleCare.Data.Models.PersonTag>
    {
        public PersonTagResponse() { }

        public string PersonTagId { get; set; }
        public string PersonId { get; set; }
        public string TagId { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.TagResponse Tag { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.PersonTag obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PersonTagId = obj.PersonTagId;
            this.PersonId = obj.PersonId;
            this.TagId = obj.TagId;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

            if (tree == null || tree[nameof(this.Tag)] != null)
                this.Tag = obj.Tag.MapToDto<PeopleCare.Data.Models.Tag, TagResponse>(context, tree?[nameof(this.Tag)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
