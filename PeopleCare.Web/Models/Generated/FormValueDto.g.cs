using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class FormValueParameter : GeneratedParameterDto<PeopleCare.Data.Models.Forms.FormValue>
    {
        public FormValueParameter() { }

        private string _FormValueId;
        private string _FormId;
        private string _FormFieldId;
        private string _Value;

        public string FormValueId
        {
            get => _FormValueId;
            set { _FormValueId = value; Changed(nameof(FormValueId)); }
        }
        public string FormId
        {
            get => _FormId;
            set { _FormId = value; Changed(nameof(FormId)); }
        }
        public string FormFieldId
        {
            get => _FormFieldId;
            set { _FormFieldId = value; Changed(nameof(FormFieldId)); }
        }
        public string Value
        {
            get => _Value;
            set { _Value = value; Changed(nameof(Value)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Forms.FormValue entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(FormValueId))) entity.FormValueId = FormValueId;
            if (ShouldMapTo(nameof(FormId))) entity.FormId = FormId;
            if (ShouldMapTo(nameof(FormFieldId))) entity.FormFieldId = FormFieldId;
            if (ShouldMapTo(nameof(Value))) entity.Value = Value;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Forms.FormValue MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.Forms.FormValue();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class FormValueResponse : GeneratedResponseDto<PeopleCare.Data.Models.Forms.FormValue>
    {
        public FormValueResponse() { }

        public string FormValueId { get; set; }
        public string FormId { get; set; }
        public string FormFieldId { get; set; }
        public string Value { get; set; }
        public PeopleCare.Web.Models.FormResponse Form { get; set; }
        public PeopleCare.Web.Models.FormFieldResponse FormField { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Forms.FormValue obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.FormValueId = obj.FormValueId;
            this.FormId = obj.FormId;
            this.FormFieldId = obj.FormFieldId;
            this.Value = obj.Value;
            if (tree == null || tree[nameof(this.Form)] != null)
                this.Form = obj.Form.MapToDto<PeopleCare.Data.Models.Forms.Form, FormResponse>(context, tree?[nameof(this.Form)]);

            if (tree == null || tree[nameof(this.FormField)] != null)
                this.FormField = obj.FormField.MapToDto<PeopleCare.Data.Models.Forms.FormField, FormFieldResponse>(context, tree?[nameof(this.FormField)]);

        }
    }
}
