using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class PersonRegionAccessParameter : GeneratedParameterDto<PeopleCare.Data.Models.PersonRegionAccess>
    {
        public PersonRegionAccessParameter() { }

        private string _PersonRegionAccessId;
        private string _PersonId;
        private string _RegionId;

        public string PersonRegionAccessId
        {
            get => _PersonRegionAccessId;
            set { _PersonRegionAccessId = value; Changed(nameof(PersonRegionAccessId)); }
        }
        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string RegionId
        {
            get => _RegionId;
            set { _RegionId = value; Changed(nameof(RegionId)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.PersonRegionAccess entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PersonRegionAccessId))) entity.PersonRegionAccessId = PersonRegionAccessId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(RegionId))) entity.RegionId = RegionId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.PersonRegionAccess MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.PersonRegionAccess();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class PersonRegionAccessResponse : GeneratedResponseDto<PeopleCare.Data.Models.PersonRegionAccess>
    {
        public PersonRegionAccessResponse() { }

        public string PersonRegionAccessId { get; set; }
        public string PersonId { get; set; }
        public string RegionId { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.RegionResponse Region { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.PersonRegionAccess obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PersonRegionAccessId = obj.PersonRegionAccessId;
            this.PersonId = obj.PersonId;
            this.RegionId = obj.RegionId;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

            if (tree == null || tree[nameof(this.Region)] != null)
                this.Region = obj.Region.MapToDto<PeopleCare.Data.Models.Region, RegionResponse>(context, tree?[nameof(this.Region)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
