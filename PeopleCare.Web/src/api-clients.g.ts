import * as $metadata from './metadata.g'
import * as $models from './models.g'
import { ModelApiClient, ServiceApiClient } from 'coalesce-vue/lib/api-client'
import type { AxiosPromise, AxiosRequestConfig, ItemResult, ListResult } from 'coalesce-vue/lib/api-client'

export class ActivityApiClient extends ModelApiClient<$models.Activity> {
  constructor() { super($metadata.Activity) }
}


export class AuditLogApiClient extends ModelApiClient<$models.AuditLog> {
  constructor() { super($metadata.AuditLog) }
}


export class AuditLogPropertyApiClient extends ModelApiClient<$models.AuditLogProperty> {
  constructor() { super($metadata.AuditLogProperty) }
}


export class DisbursementApiClient extends ModelApiClient<$models.Disbursement> {
  constructor() { super($metadata.Disbursement) }
}


export class DocumentApiClient extends ModelApiClient<$models.Document> {
  constructor() { super($metadata.Document) }
}


export class DocumentTypeApiClient extends ModelApiClient<$models.DocumentType> {
  constructor() { super($metadata.DocumentType) }
}


export class DonationApiClient extends ModelApiClient<$models.Donation> {
  constructor() { super($metadata.Donation) }
}


export class EncounterApiClient extends ModelApiClient<$models.Encounter> {
  constructor() { super($metadata.Encounter) }
}


export class EthnicityApiClient extends ModelApiClient<$models.Ethnicity> {
  constructor() { super($metadata.Ethnicity) }
}


export class FormApiClient extends ModelApiClient<$models.Form> {
  constructor() { super($metadata.Form) }
}


export class FormFieldValueApiClient extends ModelApiClient<$models.FormFieldValue> {
  constructor() { super($metadata.FormFieldValue) }
}


export class FormTypeApiClient extends ModelApiClient<$models.FormType> {
  constructor() { super($metadata.FormType) }
}


export class FormTypeFieldApiClient extends ModelApiClient<$models.FormTypeField> {
  constructor() { super($metadata.FormTypeField) }
}


export class FundingSourceApiClient extends ModelApiClient<$models.FundingSource> {
  constructor() { super($metadata.FundingSource) }
}


export class GenderApiClient extends ModelApiClient<$models.Gender> {
  constructor() { super($metadata.Gender) }
}


export class PersonApiClient extends ModelApiClient<$models.Person> {
  constructor() { super($metadata.Person) }
}


export class PersonPersonTypeApiClient extends ModelApiClient<$models.PersonPersonType> {
  constructor() { super($metadata.PersonPersonType) }
}


export class PersonProgramFundingSourceApiClient extends ModelApiClient<$models.PersonProgramFundingSource> {
  constructor() { super($metadata.PersonProgramFundingSource) }
}


export class PersonRegionAccessApiClient extends ModelApiClient<$models.PersonRegionAccess> {
  constructor() { super($metadata.PersonRegionAccess) }
}


export class PersonTagApiClient extends ModelApiClient<$models.PersonTag> {
  constructor() { super($metadata.PersonTag) }
}


export class PersonTypeApiClient extends ModelApiClient<$models.PersonType> {
  constructor() { super($metadata.PersonType) }
}


export class ProgramApiClient extends ModelApiClient<$models.Program> {
  constructor() { super($metadata.Program) }
}


export class ProgramActivityApiClient extends ModelApiClient<$models.ProgramActivity> {
  constructor() { super($metadata.ProgramActivity) }
}


export class ProgramFundingSourceApiClient extends ModelApiClient<$models.ProgramFundingSource> {
  constructor() { super($metadata.ProgramFundingSource) }
}


export class RegionApiClient extends ModelApiClient<$models.Region> {
  constructor() { super($metadata.Region) }
}


export class RelationshipApiClient extends ModelApiClient<$models.Relationship> {
  constructor() { super($metadata.Relationship) }
  public create(person: $models.Person | null, relatedPerson: $models.Person | null, relationshipTypeId: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<$models.Relationship>> {
    const $method = this.$metadata.methods.create
    const $params =  {
      person,
      relatedPerson,
      relationshipTypeId,
    }
    return this.$invoke($method, $params, $config)
  }
  
}


export class RelationshipTypeApiClient extends ModelApiClient<$models.RelationshipType> {
  constructor() { super($metadata.RelationshipType) }
}


export class RoleApiClient extends ModelApiClient<$models.Role> {
  constructor() { super($metadata.Role) }
}


export class TagApiClient extends ModelApiClient<$models.Tag> {
  constructor() { super($metadata.Tag) }
}


export class TenantApiClient extends ModelApiClient<$models.Tenant> {
  constructor() { super($metadata.Tenant) }
  public create(name: string | null, adminEmail: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.create
    const $params =  {
      name,
      adminEmail,
    }
    return this.$invoke($method, $params, $config)
  }
  
}


export class UserApiClient extends ModelApiClient<$models.User> {
  constructor() { super($metadata.User) }
  public getPhoto(id: string | null, etag?: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<File>> {
    const $method = this.$metadata.methods.getPhoto
    const $params =  {
      id,
      etag,
    }
    return this.$invoke($method, $params, $config)
  }
  
  public evict(id: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.evict
    const $params =  {
      id,
    }
    return this.$invoke($method, $params, $config)
  }
  
  public inviteUser(email: string | null, role?: $models.Role | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.inviteUser
    const $params =  {
      email,
      role,
    }
    return this.$invoke($method, $params, $config)
  }
  
  public setEmail(id: string | null, newEmail: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.setEmail
    const $params =  {
      id,
      newEmail,
    }
    return this.$invoke($method, $params, $config)
  }
  
  public sendEmailConfirmation(id: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.sendEmailConfirmation
    const $params =  {
      id,
    }
    return this.$invoke($method, $params, $config)
  }
  
  public setPassword(id: string | null, currentPassword: string | null, newPassword: string | null, confirmNewPassword: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.setPassword
    const $params =  {
      id,
      currentPassword,
      newPassword,
      confirmNewPassword,
    }
    return this.$invoke($method, $params, $config)
  }
  
}


export class UserRoleApiClient extends ModelApiClient<$models.UserRole> {
  constructor() { super($metadata.UserRole) }
}


export class SecurityServiceApiClient extends ServiceApiClient<typeof $metadata.SecurityService> {
  constructor() { super($metadata.SecurityService) }
  public whoAmI($config?: AxiosRequestConfig): AxiosPromise<ItemResult<$models.UserInfo>> {
    const $method = this.$metadata.methods.whoAmI
    const $params =  {
    }
    return this.$invoke($method, $params, $config)
  }
  
}


