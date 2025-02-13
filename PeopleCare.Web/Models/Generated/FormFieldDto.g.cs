using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class FormFieldParameter : GeneratedParameterDto<PeopleCare.Data.Models.Forms.FormField>
    {
        public FormFieldParameter() { }

        private string _FormFieldId;
        private string _Name;
        private string _Description;
        private PeopleCare.Data.Models.Forms.FormField.FormFieldType? _Type;
        private string _ValidValues;

        public string FormFieldId
        {
            get => _FormFieldId;
            set { _FormFieldId = value; Changed(nameof(FormFieldId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public string Description
        {
            get => _Description;
            set { _Description = value; Changed(nameof(Description)); }
        }
        public PeopleCare.Data.Models.Forms.FormField.FormFieldType? Type
        {
            get => _Type;
            set { _Type = value; Changed(nameof(Type)); }
        }
        public string ValidValues
        {
            get => _ValidValues;
            set { _ValidValues = value; Changed(nameof(ValidValues)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Forms.FormField entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(FormFieldId))) entity.FormFieldId = FormFieldId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(Type))) entity.Type = (Type ?? entity.Type);
            if (ShouldMapTo(nameof(ValidValues))) entity.ValidValues = ValidValues;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Forms.FormField MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Models.Forms.FormField()
            {
                Name = Name,
                Type = (Type ?? default),
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(FormFieldId))) entity.FormFieldId = FormFieldId;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(ValidValues))) entity.ValidValues = ValidValues;

            return entity;
        }
    }

    public partial class FormFieldResponse : GeneratedResponseDto<PeopleCare.Data.Models.Forms.FormField>
    {
        public FormFieldResponse() { }

        public string FormFieldId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PeopleCare.Data.Models.Forms.FormField.FormFieldType? Type { get; set; }
        public string ValidValues { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Forms.FormField obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.FormFieldId = obj.FormFieldId;
            this.Name = obj.Name;
            this.Description = obj.Description;
            this.Type = obj.Type;
            this.ValidValues = obj.ValidValues;
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
