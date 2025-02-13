using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class PersonPersonTypeParameter : GeneratedParameterDto<PeopleCare.Data.Models.PersonPersonType>
    {
        public PersonPersonTypeParameter() { }

        private string _PersonPersonTypeId;
        private string _PersonId;
        private string _PersonTypeId;

        public string PersonPersonTypeId
        {
            get => _PersonPersonTypeId;
            set { _PersonPersonTypeId = value; Changed(nameof(PersonPersonTypeId)); }
        }
        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string PersonTypeId
        {
            get => _PersonTypeId;
            set { _PersonTypeId = value; Changed(nameof(PersonTypeId)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.PersonPersonType entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PersonPersonTypeId))) entity.PersonPersonTypeId = PersonPersonTypeId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(PersonTypeId))) entity.PersonTypeId = PersonTypeId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.PersonPersonType MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.PersonPersonType();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class PersonPersonTypeResponse : GeneratedResponseDto<PeopleCare.Data.Models.PersonPersonType>
    {
        public PersonPersonTypeResponse() { }

        public string PersonPersonTypeId { get; set; }
        public string PersonId { get; set; }
        public string PersonTypeId { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.PersonTypeResponse PersonType { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.PersonPersonType obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PersonPersonTypeId = obj.PersonPersonTypeId;
            this.PersonId = obj.PersonId;
            this.PersonTypeId = obj.PersonTypeId;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

            if (tree == null || tree[nameof(this.PersonType)] != null)
                this.PersonType = obj.PersonType.MapToDto<PeopleCare.Data.Models.PersonType, PersonTypeResponse>(context, tree?[nameof(this.PersonType)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
