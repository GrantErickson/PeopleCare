using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace PeopleCare.Web.Models
{
    public partial class UserInfoParameter : GeneratedParameterDto<PeopleCare.Data.Auth.UserInfo>
    {
        public UserInfoParameter() { }

        private string _Id;
        private string _UserName;
        private string _Email;
        private string _FullName;
        private System.Collections.Generic.ICollection<string> _Roles;
        private System.Collections.Generic.ICollection<string> _Permissions;
        private string _TenantId;
        private string _TenantName;

        public string Id
        {
            get => _Id;
            set { _Id = value; Changed(nameof(Id)); }
        }
        public string UserName
        {
            get => _UserName;
            set { _UserName = value; Changed(nameof(UserName)); }
        }
        public string Email
        {
            get => _Email;
            set { _Email = value; Changed(nameof(Email)); }
        }
        public string FullName
        {
            get => _FullName;
            set { _FullName = value; Changed(nameof(FullName)); }
        }
        public System.Collections.Generic.ICollection<string> Roles
        {
            get => _Roles;
            set { _Roles = value; Changed(nameof(Roles)); }
        }
        public System.Collections.Generic.ICollection<string> Permissions
        {
            get => _Permissions;
            set { _Permissions = value; Changed(nameof(Permissions)); }
        }
        public string TenantId
        {
            get => _TenantId;
            set { _TenantId = value; Changed(nameof(TenantId)); }
        }
        public string TenantName
        {
            get => _TenantName;
            set { _TenantName = value; Changed(nameof(TenantName)); }
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(PeopleCare.Data.Auth.UserInfo entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(Id))) entity.Id = Id;
            if (ShouldMapTo(nameof(UserName))) entity.UserName = UserName;
            if (ShouldMapTo(nameof(Email))) entity.Email = Email;
            if (ShouldMapTo(nameof(FullName))) entity.FullName = FullName;
            if (ShouldMapTo(nameof(Roles))) entity.Roles = Roles;
            if (ShouldMapTo(nameof(Permissions))) entity.Permissions = Permissions;
            if (ShouldMapTo(nameof(TenantId))) entity.TenantId = TenantId;
            if (ShouldMapTo(nameof(TenantName))) entity.TenantName = TenantName;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override PeopleCare.Data.Auth.UserInfo MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new PeopleCare.Data.Auth.UserInfo()
            {
                Roles = Roles,
                Permissions = Permissions,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(Id))) entity.Id = Id;
            if (ShouldMapTo(nameof(UserName))) entity.UserName = UserName;
            if (ShouldMapTo(nameof(Email))) entity.Email = Email;
            if (ShouldMapTo(nameof(FullName))) entity.FullName = FullName;
            if (ShouldMapTo(nameof(TenantId))) entity.TenantId = TenantId;
            if (ShouldMapTo(nameof(TenantName))) entity.TenantName = TenantName;

            return entity;
        }
    }

    public partial class UserInfoResponse : GeneratedResponseDto<PeopleCare.Data.Auth.UserInfo>
    {
        public UserInfoResponse() { }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public System.Collections.Generic.ICollection<string> Roles { get; set; }
        public System.Collections.Generic.ICollection<string> Permissions { get; set; }
        public string TenantId { get; set; }
        public string TenantName { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(PeopleCare.Data.Auth.UserInfo obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.Id = obj.Id;
            this.UserName = obj.UserName;
            this.Email = obj.Email;
            this.FullName = obj.FullName;
            this.Roles = obj.Roles;
            this.Permissions = obj.Permissions;
            this.TenantId = obj.TenantId;
            this.TenantName = obj.TenantName;
        }
    }
}
