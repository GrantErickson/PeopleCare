using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class DocumentParameter : GeneratedParameterDto<PeopleCare.Data.Models.Document>
    {
        public DocumentParameter() { }

        private string _DocumentId;
        private string _PersonId;
        private string _DocumentName;
        private string _Url;
        private string _DocumentTypeId;

        public string DocumentId
        {
            get => _DocumentId;
            set { _DocumentId = value; Changed(nameof(DocumentId)); }
        }
        public string PersonId
        {
            get => _PersonId;
            set { _PersonId = value; Changed(nameof(PersonId)); }
        }
        public string DocumentName
        {
            get => _DocumentName;
            set { _DocumentName = value; Changed(nameof(DocumentName)); }
        }
        public string Url
        {
            get => _Url;
            set { _Url = value; Changed(nameof(Url)); }
        }
        public string DocumentTypeId
        {
            get => _DocumentTypeId;
            set { _DocumentTypeId = value; Changed(nameof(DocumentTypeId)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.Document entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(DocumentId))) entity.DocumentId = DocumentId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(DocumentName))) entity.DocumentName = DocumentName;
            if (ShouldMapTo(nameof(Url))) entity.Url = Url;
            if (ShouldMapTo(nameof(DocumentTypeId))) entity.DocumentTypeId = DocumentTypeId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.Document MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Models.Document()
            {
                DocumentName = DocumentName,
                Url = Url,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(DocumentId))) entity.DocumentId = DocumentId;
            if (ShouldMapTo(nameof(PersonId))) entity.PersonId = PersonId;
            if (ShouldMapTo(nameof(DocumentTypeId))) entity.DocumentTypeId = DocumentTypeId;

            return entity;
        }
    }

    public partial class DocumentResponse : GeneratedResponseDto<PeopleCare.Data.Models.Document>
    {
        public DocumentResponse() { }

        public string DocumentId { get; set; }
        public string PersonId { get; set; }
        public string DocumentName { get; set; }
        public string Url { get; set; }
        public string DocumentTypeId { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public PeopleCare.Web.Models.PersonResponse Person { get; set; }
        public PeopleCare.Web.Models.DocumentTypeResponse DocumentType { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.Document obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.DocumentId = obj.DocumentId;
            this.PersonId = obj.PersonId;
            this.DocumentName = obj.DocumentName;
            this.Url = obj.Url;
            this.DocumentTypeId = obj.DocumentTypeId;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Person)] != null)
                this.Person = obj.Person.MapToDto<PeopleCare.Data.Models.Person, PersonResponse>(context, tree?[nameof(this.Person)]);

            if (tree == null || tree[nameof(this.DocumentType)] != null)
                this.DocumentType = obj.DocumentType.MapToDto<PeopleCare.Data.Models.DocumentType, DocumentTypeResponse>(context, tree?[nameof(this.DocumentType)]);

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
