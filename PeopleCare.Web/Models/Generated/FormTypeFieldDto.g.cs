using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class FormTypeFieldParameter : GeneratedParameterDto<PeopleCare.Data.Models.Forms.FormTypeField>
    {
        public FormTypeFieldParameter() { }

        private string _FormTypeFieldId;
        private string _FormTypeId;
        private string _Name;
        private string _Description;
        private PeopleCare.Data.Models.Forms.FormTypeField.FormFieldType? _Type;
        private string _ValidValues;

        public string FormTypeFieldId
        {
            get => _FormTypeFieldId;
            set { _FormTypeFieldId = value; Changed(nameof(FormTypeFieldId)); }
        }
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
        public string Description
        {
            get => _Description;
            set { _Description = value; Changed(nameof(Description)); }
        }
        public PeopleCare.Data.Models.Forms.FormTypeField.FormFieldType? Type
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
        public override void MapTo(PeopleCare.Data.Models.Forms.FormTypeField entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(FormTypeFieldId))) entity.FormTypeFieldId = FormTypeFieldId;
            if (ShouldMapTo(nameof(FormTypeId))) entity.FormTypeId = FormTypeId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(Type))) entity.Type = (Type ?? entity.Type);
            if (ShouldMapTo(nameof(ValidValues))) entity.ValidValues = ValidValues;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Forms.FormTypeField MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Models.Forms.FormTypeField()
            {
                Name = Name,
                Type = (Type ?? default),
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(FormTypeFieldId))) entity.FormTypeFieldId = FormTypeFieldId;
            if (ShouldMapTo(nameof(FormTypeId))) entity.FormTypeId = FormTypeId;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(ValidValues))) entity.ValidValues = ValidValues;

            return entity;
        }
    }

    public partial class FormTypeFieldResponse : GeneratedResponseDto<PeopleCare.Data.Models.Forms.FormTypeField>
    {
        public FormTypeFieldResponse() { }

        public string FormTypeFieldId { get; set; }
        public string FormTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PeopleCare.Data.Models.Forms.FormTypeField.FormFieldType? Type { get; set; }
        public string ValidValues { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.FormTypeResponse FormType { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Forms.FormTypeField obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.FormTypeFieldId = obj.FormTypeFieldId;
            this.FormTypeId = obj.FormTypeId;
            this.Name = obj.Name;
            this.Description = obj.Description;
            this.Type = obj.Type;
            this.ValidValues = obj.ValidValues;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.FormType)] != null)
                this.FormType = obj.FormType.MapToDto<PeopleCare.Data.Models.Forms.FormType, FormTypeResponse>(context, tree?[nameof(this.FormType)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
