using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class FormFieldValueParameter : GeneratedParameterDto<PeopleCare.Data.Models.Forms.FormFieldValue>
    {
        public FormFieldValueParameter() { }

        private string _FormFieldValueId;
        private string _FormId;
        private string _FormTypeFieldId;
        private string _Value;

        public string FormFieldValueId
        {
            get => _FormFieldValueId;
            set { _FormFieldValueId = value; Changed(nameof(FormFieldValueId)); }
        }
        public string FormId
        {
            get => _FormId;
            set { _FormId = value; Changed(nameof(FormId)); }
        }
        public string FormTypeFieldId
        {
            get => _FormTypeFieldId;
            set { _FormTypeFieldId = value; Changed(nameof(FormTypeFieldId)); }
        }
        public string Value
        {
            get => _Value;
            set { _Value = value; Changed(nameof(Value)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Forms.FormFieldValue entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(FormFieldValueId))) entity.FormFieldValueId = FormFieldValueId;
            if (ShouldMapTo(nameof(FormId))) entity.FormId = FormId;
            if (ShouldMapTo(nameof(FormTypeFieldId))) entity.FormTypeFieldId = FormTypeFieldId;
            if (ShouldMapTo(nameof(Value))) entity.Value = Value;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Forms.FormFieldValue MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.Forms.FormFieldValue();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class FormFieldValueResponse : GeneratedResponseDto<PeopleCare.Data.Models.Forms.FormFieldValue>
    {
        public FormFieldValueResponse() { }

        public string FormFieldValueId { get; set; }
        public string FormId { get; set; }
        public string FormTypeFieldId { get; set; }
        public string Value { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.FormResponse Form { get; set; }
        public PeopleCare.Web.Models.FormTypeFieldResponse FormTypeField { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Forms.FormFieldValue obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.FormFieldValueId = obj.FormFieldValueId;
            this.FormId = obj.FormId;
            this.FormTypeFieldId = obj.FormTypeFieldId;
            this.Value = obj.Value;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Form)] != null)
                this.Form = obj.Form.MapToDto<PeopleCare.Data.Models.Forms.Form, FormResponse>(context, tree?[nameof(this.Form)]);

            if (tree == null || tree[nameof(this.FormTypeField)] != null)
                this.FormTypeField = obj.FormTypeField.MapToDto<PeopleCare.Data.Models.Forms.FormTypeField, FormTypeFieldResponse>(context, tree?[nameof(this.FormTypeField)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
