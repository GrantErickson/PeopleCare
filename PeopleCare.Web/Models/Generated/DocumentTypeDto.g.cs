using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class DocumentTypeParameter : GeneratedParameterDto<PeopleCare.Data.Models.DocumentType>
    {
        public DocumentTypeParameter() { }

        private string _DocumentTypeId;
        private string _Name;

        public string DocumentTypeId
        {
            get => _DocumentTypeId;
            set { _DocumentTypeId = value; Changed(nameof(DocumentTypeId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Models.DocumentType entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(DocumentTypeId))) entity.DocumentTypeId = DocumentTypeId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Models.DocumentType MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Models.DocumentType()
            {
                Name = Name,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(DocumentTypeId))) entity.DocumentTypeId = DocumentTypeId;

            return entity;
        }
    }

    public partial class DocumentTypeResponse : GeneratedResponseDto<PeopleCare.Data.Models.DocumentType>
    {
        public DocumentTypeResponse() { }

        public string DocumentTypeId { get; set; }
        public string Name { get; set; }
        public string ModifiedById { get; set; }
        public System.DateTimeOffset? ModifiedOn { get; set; }
        public string CreatedById { get; set; }
        public System.DateTimeOffset? CreatedOn { get; set; }
        public System.Collections.Generic.ICollection<PeopleCare.Web.Models.DocumentResponse> Documents { get; set; }
        public PeopleCare.Web.Models.UserResponse ModifiedBy { get; set; }
        public PeopleCare.Web.Models.UserResponse CreatedBy { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Models.DocumentType obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.DocumentTypeId = obj.DocumentTypeId;
            this.Name = obj.Name;
            this.ModifiedById = obj.ModifiedById;
            this.ModifiedOn = obj.ModifiedOn;
            this.CreatedById = obj.CreatedById;
            this.CreatedOn = obj.CreatedOn;
            var propValDocuments = obj.Documents;
            if (propValDocuments != null && (tree == null || tree[nameof(this.Documents)] != null))
            {
                this.Documents = propValDocuments
                    .OrderBy(f => f.DocumentId)
                    .Select(f => f.MapToDto<PeopleCare.Data.Models.Document, DocumentResponse>(context, tree?[nameof(this.Documents)])).ToList();
            }
            else if (propValDocuments == null && tree?[nameof(this.Documents)] != null)
            {
                this.Documents = new DocumentResponse[0];
            }

            if (tree == null || tree[nameof(this.ModifiedBy)] != null)
                this.ModifiedBy = obj.ModifiedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.ModifiedBy)]);

            if (tree == null || tree[nameof(this.CreatedBy)] != null)
                this.CreatedBy = obj.CreatedBy.MapToDto<PeopleCare.Data.Models.User, UserResponse>(context, tree?[nameof(this.CreatedBy)]);

        }
    }
}
