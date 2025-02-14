using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class RegionParameter : GeneratedParameterDto<PeopleCare.Data.Models.Region>
    {
        public RegionParameter() { }

        private string _RegionId;
        private string _Name;
        private string _Code;
        private string _ParentRegionId;

        public string RegionId
        {
            get => _RegionId;
            set { _RegionId = value; Changed(nameof(RegionId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public string Code
        {
            get => _Code;
            set { _Code = value; Changed(nameof(Code)); }
        }
        public string ParentRegionId
        {
            get => _ParentRegionId;
            set { _ParentRegionId = value; Changed(nameof(ParentRegionId)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Region entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(RegionId))) entity.RegionId = RegionId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Code))) entity.Code = Code;
            if (ShouldMapTo(nameof(ParentRegionId))) entity.ParentRegionId = ParentRegionId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Region MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Models.Region()
            {
                Name = Name,
                Code = Code,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(RegionId))) entity.RegionId = RegionId;
            if (ShouldMapTo(nameof(ParentRegionId))) entity.ParentRegionId = ParentRegionId;

            return entity;
        }
    }

    public partial class RegionResponse : GeneratedResponseDto<PeopleCare.Data.Models.Region>
    {
        public RegionResponse() { }

        public string RegionId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ParentRegionId { get; set; }
        public int? Level { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.RegionResponse ParentRegion { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.RegionResponse> Children { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Region obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.RegionId = obj.RegionId;
            this.Name = obj.Name;
            this.Code = obj.Code;
            this.ParentRegionId = obj.ParentRegionId;
            this.Level = obj.Level;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.ParentRegion)] != null)
                this.ParentRegion = obj.ParentRegion.MapToDto<PeopleCare.Data.Models.Region, RegionResponse>(context, tree?[nameof(this.ParentRegion)]);

            var propValChildren = obj.Children;
            if (propValChildren != null && (tree == null || tree[nameof(this.Children)] != null))
            {
                this.Children = propValChildren
                    .OrderBy(f => f.Name)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Region, RegionResponse>(context, tree?[nameof(this.Children)])).ToList();
            }
            else if (propValChildren == null && tree?[nameof(this.Children)] != null)
            {
                this.Children = new RegionResponse[0];
            }

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
