using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class FormParameter : GeneratedParameterDto<PeopleCare.Data.Models.Forms.Form>
    {
        public FormParameter() { }

        private string _FormId;
        private string _PersonId;
        private string _FormTypeId;
        private System.DateTime? _Date;

        public string FormId
        {
            get => _FormId;
            set { _FormId = value; Changed(nameof(FormId)); }
        }
        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string FormTypeId
        {
            get => _FormTypeId;
            set { _FormTypeId = value; Changed(nameof(FormTypeId)); }
        }
        public System.DateTime? Date
        {
            get => _Date;
            set { _Date = value; Changed(nameof(Date)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Forms.Form entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(FormId))) entity.FormId = FormId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(FormTypeId))) entity.FormTypeId = FormTypeId;
            if (ShouldMapTo(nameof(Date))) entity.Date = (Date ?? entity.Date);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Forms.Form MapToNew(IMappingContext context)
        {
            var entity = new PeopleCare.Data.Models.Forms.Form();
            MapTo(entity, context);
            return entity;
        }
    }

    public partial class FormResponse : GeneratedResponseDto<PeopleCare.Data.Models.Forms.Form>
    {
        public FormResponse() { }

        public string FormId { get; set; }
        public string PersonId { get; set; }
        public string FormTypeId { get; set; }
        public System.DateTime? Date { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.FormTypeResponse FormType { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.FormFieldValueResponse> FormValues { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Forms.Form obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.FormId = obj.FormId;
            this.PersonId = obj.PersonId;
            this.FormTypeId = obj.FormTypeId;
            this.Date = obj.Date;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

            if (tree == null || tree[nameof(this.FormType)] != null)
                this.FormType = obj.FormType.MapToDto<PeopleCare.Data.Models.Forms.FormType, FormTypeResponse>(context, tree?[nameof(this.FormType)]);

            var propValFormValues = obj.FormValues;
            if (propValFormValues != null && (tree == null || tree[nameof(this.FormValues)] != null))
            {
                this.FormValues = propValFormValues
                    .OrderBy(f => f.FormFieldValueId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Forms.FormFieldValue, FormFieldValueResponse>(context, tree?[nameof(this.FormValues)])).ToList();
            }
            else if (propValFormValues == null && tree?[nameof(this.FormValues)] != null)
            {
                this.FormValues = new FormFieldValueResponse[0];
            }

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
