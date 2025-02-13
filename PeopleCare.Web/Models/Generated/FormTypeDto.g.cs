using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class FormTypeParameter : GeneratedParameterDto<PeopleCare.Data.Models.Forms.FormType>
    {
        public FormTypeParameter() { }

        private string _FormTypeId;
        private string _Name;

        public string FormTypeId
        {
            get => _FormTypeId;
            set { _FormTypeId = value; Changed(nameof(FormTypeId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Forms.FormType entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(FormTypeId))) entity.FormTypeId = FormTypeId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Forms.FormType MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.Forms.FormType();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class FormTypeResponse : GeneratedResponseDto<PeopleCare.Data.Models.Forms.FormType>
    {
        public FormTypeResponse() { }

        public string FormTypeId { get; set; }
        public string Name { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.FormResponse> Forms { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.FormFieldResponse> Fields { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Forms.FormType obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.FormTypeId = obj.FormTypeId;
            this.Name = obj.Name;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            var propValForms = obj.Forms;
            if (propValForms != null && (tree == null || tree[nameof(this.Forms)] != null))
            {
                this.Forms = propValForms
                    .OrderBy(f => f.FormId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Forms.Form, FormResponse>(context, tree?[nameof(this.Forms)])).ToList();
            }
            else if (propValForms == null && tree?[nameof(this.Forms)] != null)
            {
                this.Forms = new FormResponse[0];
            }

            var propValFields = obj.Fields;
            if (propValFields != null && (tree == null || tree[nameof(this.Fields)] != null))
            {
                this.Fields = propValFields
                    .OrderBy(f => f.Name)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Forms.FormField, FormFieldResponse>(context, tree?[nameof(this.Fields)])).ToList();
            }
            else if (propValFields == null && tree?[nameof(this.Fields)] != null)
            {
                this.Fields = new FormFieldResponse[0];
            }

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
