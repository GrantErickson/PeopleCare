using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class PersonTypeParameter : GeneratedParameterDto<PeopleCare.Data.Models.PersonType>
    {
        public PersonTypeParameter() { }

        private string _PersonTypeId;
        private string _Name;
        private bool? _HasCareNeeds;
        private bool? _HasCareAssets;
        private bool? _IsOrganization;

        public string PersonTypeId
        {
            get => _PersonTypeId;
            set { _PersonTypeId = value; Changed(nameof(PersonTypeId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public bool? HasCareNeeds
        {
            get => _HasCareNeeds;
            set { _HasCareNeeds = value; Changed(nameof(HasCareNeeds)); }
        }
        public bool? HasCareAssets
        {
            get => _HasCareAssets;
            set { _HasCareAssets = value; Changed(nameof(HasCareAssets)); }
        }
        public bool? IsOrganization
        {
            get => _IsOrganization;
            set { _IsOrganization = value; Changed(nameof(IsOrganization)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.PersonType entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PersonTypeId))) entity.PersonTypeId = PersonTypeId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(HasCareNeeds))) entity.HasCareNeeds = (HasCareNeeds ?? entity.HasCareNeeds);
            if (ShouldMapTo(nameof(HasCareAssets))) entity.HasCareAssets = (HasCareAssets ?? entity.HasCareAssets);
            if (ShouldMapTo(nameof(IsOrganization))) entity.IsOrganization = (IsOrganization ?? entity.IsOrganization);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.PersonType MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Models.PersonType()
            {
                Name = Name,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(PersonTypeId))) entity.PersonTypeId = PersonTypeId;
            if (ShouldMapTo(nameof(HasCareNeeds))) entity.HasCareNeeds = (HasCareNeeds ?? entity.HasCareNeeds);
            if (ShouldMapTo(nameof(HasCareAssets))) entity.HasCareAssets = (HasCareAssets ?? entity.HasCareAssets);
            if (ShouldMapTo(nameof(IsOrganization))) entity.IsOrganization = (IsOrganization ?? entity.IsOrganization);

            return entity;
        }
    }

    public partial class PersonTypeResponse : GeneratedResponseDto<PeopleCare.Data.Models.PersonType>
    {
        public PersonTypeResponse() { }

        public string PersonTypeId { get; set; }
        public string Name { get; set; }
        public bool? HasCareNeeds { get; set; }
        public bool? HasCareAssets { get; set; }
        public bool? IsOrganization { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.PersonType obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PersonTypeId = obj.PersonTypeId;
            this.Name = obj.Name;
            this.HasCareNeeds = obj.HasCareNeeds;
            this.HasCareAssets = obj.HasCareAssets;
            this.IsOrganization = obj.IsOrganization;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
