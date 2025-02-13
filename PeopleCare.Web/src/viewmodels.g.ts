import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ViewModelCollection, ServiceViewModel, type DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface ActivityViewModel extends $models.Activity {
  activityId: string | null;
  name: string | null;
  description: string | null;
  date: Date | null;
  durationInMinutes: number | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class ActivityViewModel extends ViewModel<$models.Activity, $apiClients.ActivityApiClient, string> implements $models.Activity  {
  
  constructor(initialData?: DeepPartial<$models.Activity> | null) {
    super($metadata.Activity, new $apiClients.ActivityApiClient(), initialData)
  }
}
defineProps(ActivityViewModel, $metadata.Activity)

export class ActivityListViewModel extends ListViewModel<$models.Activity, $apiClients.ActivityApiClient, ActivityViewModel> {
  
  constructor() {
    super($metadata.Activity, new $apiClients.ActivityApiClient())
  }
}


export interface AuditLogViewModel extends $models.AuditLog {
  userId: string | null;
  get user(): UserViewModel | null;
  set user(value: UserViewModel | $models.User | null);
  id: number | null;
  type: string | null;
  keyValue: string | null;
  description: string | null;
  state: $models.AuditEntryState | null;
  date: Date | null;
  get properties(): ViewModelCollection<AuditLogPropertyViewModel, $models.AuditLogProperty>;
  set properties(value: (AuditLogPropertyViewModel | $models.AuditLogProperty)[] | null);
  clientIp: string | null;
  referrer: string | null;
  endpoint: string | null;
}
export class AuditLogViewModel extends ViewModel<$models.AuditLog, $apiClients.AuditLogApiClient, number> implements $models.AuditLog  {
  static DataSources = $models.AuditLog.DataSources;
  
  
  public addToProperties(initialData?: DeepPartial<$models.AuditLogProperty> | null) {
    return this.$addChild('properties', initialData) as AuditLogPropertyViewModel
  }
  
  constructor(initialData?: DeepPartial<$models.AuditLog> | null) {
    super($metadata.AuditLog, new $apiClients.AuditLogApiClient(), initialData)
  }
}
defineProps(AuditLogViewModel, $metadata.AuditLog)

export class AuditLogListViewModel extends ListViewModel<$models.AuditLog, $apiClients.AuditLogApiClient, AuditLogViewModel> {
  static DataSources = $models.AuditLog.DataSources;
  
  constructor() {
    super($metadata.AuditLog, new $apiClients.AuditLogApiClient())
  }
}


export interface AuditLogPropertyViewModel extends $models.AuditLogProperty {
  id: number | null;
  parentId: number | null;
  propertyName: string | null;
  oldValue: string | null;
  oldValueDescription: string | null;
  newValue: string | null;
  newValueDescription: string | null;
}
export class AuditLogPropertyViewModel extends ViewModel<$models.AuditLogProperty, $apiClients.AuditLogPropertyApiClient, number> implements $models.AuditLogProperty  {
  
  constructor(initialData?: DeepPartial<$models.AuditLogProperty> | null) {
    super($metadata.AuditLogProperty, new $apiClients.AuditLogPropertyApiClient(), initialData)
  }
}
defineProps(AuditLogPropertyViewModel, $metadata.AuditLogProperty)

export class AuditLogPropertyListViewModel extends ListViewModel<$models.AuditLogProperty, $apiClients.AuditLogPropertyApiClient, AuditLogPropertyViewModel> {
  
  constructor() {
    super($metadata.AuditLogProperty, new $apiClients.AuditLogPropertyApiClient())
  }
}


export interface DisbursementViewModel extends $models.Disbursement {
  disbursementId: string | null;
  personId: string | null;
  get person(): PersonViewModel | null;
  set person(value: PersonViewModel | $models.Person | null);
  donationId: string | null;
  get donation(): DonationViewModel | null;
  set donation(value: DonationViewModel | $models.Donation | null);
  regionId: string | null;
  get region(): RegionViewModel | null;
  set region(value: RegionViewModel | $models.Region | null);
  description: string | null;
  date: Date | null;
  value: number | null;
  quantity: number | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class DisbursementViewModel extends ViewModel<$models.Disbursement, $apiClients.DisbursementApiClient, string> implements $models.Disbursement  {
  
  constructor(initialData?: DeepPartial<$models.Disbursement> | null) {
    super($metadata.Disbursement, new $apiClients.DisbursementApiClient(), initialData)
  }
}
defineProps(DisbursementViewModel, $metadata.Disbursement)

export class DisbursementListViewModel extends ListViewModel<$models.Disbursement, $apiClients.DisbursementApiClient, DisbursementViewModel> {
  
  constructor() {
    super($metadata.Disbursement, new $apiClients.DisbursementApiClient())
  }
}


export interface DonationViewModel extends $models.Donation {
  donationId: string | null;
  personId: string | null;
  get person(): PersonViewModel | null;
  set person(value: PersonViewModel | $models.Person | null);
  regionId: string | null;
  get region(): RegionViewModel | null;
  set region(value: RegionViewModel | $models.Region | null);
  description: string | null;
  isInKind: boolean | null;
  value: number | null;
  quantity: number | null;
  date: Date | null;
  get disbursements(): ViewModelCollection<DisbursementViewModel, $models.Disbursement>;
  set disbursements(value: (DisbursementViewModel | $models.Disbursement)[] | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class DonationViewModel extends ViewModel<$models.Donation, $apiClients.DonationApiClient, string> implements $models.Donation  {
  
  
  public addToDisbursements(initialData?: DeepPartial<$models.Disbursement> | null) {
    return this.$addChild('disbursements', initialData) as DisbursementViewModel
  }
  
  constructor(initialData?: DeepPartial<$models.Donation> | null) {
    super($metadata.Donation, new $apiClients.DonationApiClient(), initialData)
  }
}
defineProps(DonationViewModel, $metadata.Donation)

export class DonationListViewModel extends ListViewModel<$models.Donation, $apiClients.DonationApiClient, DonationViewModel> {
  
  constructor() {
    super($metadata.Donation, new $apiClients.DonationApiClient())
  }
}


export interface EncounterViewModel extends $models.Encounter {
  encounterId: string | null;
  personId: string | null;
  get person(): PersonViewModel | null;
  set person(value: PersonViewModel | $models.Person | null);
  contactedById: string | null;
  get contactedBy(): PersonViewModel | null;
  set contactedBy(value: PersonViewModel | $models.Person | null);
  regionId: string | null;
  get region(): RegionViewModel | null;
  set region(value: RegionViewModel | $models.Region | null);
  encounterTypeId: string | null;
  encounterType: $models.EncounterType | null;
  notes: string | null;
  location: string | null;
  date: Date | null;
  durationInMinutes: number | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class EncounterViewModel extends ViewModel<$models.Encounter, $apiClients.EncounterApiClient, string> implements $models.Encounter  {
  
  constructor(initialData?: DeepPartial<$models.Encounter> | null) {
    super($metadata.Encounter, new $apiClients.EncounterApiClient(), initialData)
  }
}
defineProps(EncounterViewModel, $metadata.Encounter)

export class EncounterListViewModel extends ListViewModel<$models.Encounter, $apiClients.EncounterApiClient, EncounterViewModel> {
  
  constructor() {
    super($metadata.Encounter, new $apiClients.EncounterApiClient())
  }
}


export interface EthnicityViewModel extends $models.Ethnicity {
  ethnicityId: string | null;
  name: string | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class EthnicityViewModel extends ViewModel<$models.Ethnicity, $apiClients.EthnicityApiClient, string> implements $models.Ethnicity  {
  
  constructor(initialData?: DeepPartial<$models.Ethnicity> | null) {
    super($metadata.Ethnicity, new $apiClients.EthnicityApiClient(), initialData)
  }
}
defineProps(EthnicityViewModel, $metadata.Ethnicity)

export class EthnicityListViewModel extends ListViewModel<$models.Ethnicity, $apiClients.EthnicityApiClient, EthnicityViewModel> {
  
  constructor() {
    super($metadata.Ethnicity, new $apiClients.EthnicityApiClient())
  }
}


export interface FormViewModel extends $models.Form {
  formId: string | null;
  formTypeId: string | null;
  get formType(): FormTypeViewModel | null;
  set formType(value: FormTypeViewModel | $models.FormType | null);
  date: Date | null;
  get formValues(): ViewModelCollection<FormValueViewModel, $models.FormValue>;
  set formValues(value: (FormValueViewModel | $models.FormValue)[] | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class FormViewModel extends ViewModel<$models.Form, $apiClients.FormApiClient, string> implements $models.Form  {
  
  
  public addToFormValues(initialData?: DeepPartial<$models.FormValue> | null) {
    return this.$addChild('formValues', initialData) as FormValueViewModel
  }
  
  constructor(initialData?: DeepPartial<$models.Form> | null) {
    super($metadata.Form, new $apiClients.FormApiClient(), initialData)
  }
}
defineProps(FormViewModel, $metadata.Form)

export class FormListViewModel extends ListViewModel<$models.Form, $apiClients.FormApiClient, FormViewModel> {
  
  constructor() {
    super($metadata.Form, new $apiClients.FormApiClient())
  }
}


export interface FormFieldViewModel extends $models.FormField {
  formFieldId: string | null;
  name: string | null;
  description: string | null;
  type: $models.FormFieldType | null;
  validValues: string | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class FormFieldViewModel extends ViewModel<$models.FormField, $apiClients.FormFieldApiClient, string> implements $models.FormField  {
  
  constructor(initialData?: DeepPartial<$models.FormField> | null) {
    super($metadata.FormField, new $apiClients.FormFieldApiClient(), initialData)
  }
}
defineProps(FormFieldViewModel, $metadata.FormField)

export class FormFieldListViewModel extends ListViewModel<$models.FormField, $apiClients.FormFieldApiClient, FormFieldViewModel> {
  
  constructor() {
    super($metadata.FormField, new $apiClients.FormFieldApiClient())
  }
}


export interface FormTypeViewModel extends $models.FormType {
  formTypeId: string | null;
  name: string | null;
  get forms(): ViewModelCollection<FormViewModel, $models.Form>;
  set forms(value: (FormViewModel | $models.Form)[] | null);
  get fields(): ViewModelCollection<FormFieldViewModel, $models.FormField>;
  set fields(value: (FormFieldViewModel | $models.FormField)[] | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class FormTypeViewModel extends ViewModel<$models.FormType, $apiClients.FormTypeApiClient, string> implements $models.FormType  {
  
  
  public addToForms(initialData?: DeepPartial<$models.Form> | null) {
    return this.$addChild('forms', initialData) as FormViewModel
  }
  
  constructor(initialData?: DeepPartial<$models.FormType> | null) {
    super($metadata.FormType, new $apiClients.FormTypeApiClient(), initialData)
  }
}
defineProps(FormTypeViewModel, $metadata.FormType)

export class FormTypeListViewModel extends ListViewModel<$models.FormType, $apiClients.FormTypeApiClient, FormTypeViewModel> {
  
  constructor() {
    super($metadata.FormType, new $apiClients.FormTypeApiClient())
  }
}


export interface FormValueViewModel extends $models.FormValue {
  formValueId: string | null;
  formId: string | null;
  get form(): FormViewModel | null;
  set form(value: FormViewModel | $models.Form | null);
  formFieldId: string | null;
  get formField(): FormFieldViewModel | null;
  set formField(value: FormFieldViewModel | $models.FormField | null);
  value: string | null;
}
export class FormValueViewModel extends ViewModel<$models.FormValue, $apiClients.FormValueApiClient, string> implements $models.FormValue  {
  
  constructor(initialData?: DeepPartial<$models.FormValue> | null) {
    super($metadata.FormValue, new $apiClients.FormValueApiClient(), initialData)
  }
}
defineProps(FormValueViewModel, $metadata.FormValue)

export class FormValueListViewModel extends ListViewModel<$models.FormValue, $apiClients.FormValueApiClient, FormValueViewModel> {
  
  constructor() {
    super($metadata.FormValue, new $apiClients.FormValueApiClient())
  }
}


export interface FundingSourceViewModel extends $models.FundingSource {
  fundingSourceId: string | null;
  name: string | null;
  get programs(): ViewModelCollection<ProgramViewModel, $models.Program>;
  set programs(value: (ProgramViewModel | $models.Program)[] | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class FundingSourceViewModel extends ViewModel<$models.FundingSource, $apiClients.FundingSourceApiClient, string> implements $models.FundingSource  {
  
  constructor(initialData?: DeepPartial<$models.FundingSource> | null) {
    super($metadata.FundingSource, new $apiClients.FundingSourceApiClient(), initialData)
  }
}
defineProps(FundingSourceViewModel, $metadata.FundingSource)

export class FundingSourceListViewModel extends ListViewModel<$models.FundingSource, $apiClients.FundingSourceApiClient, FundingSourceViewModel> {
  
  constructor() {
    super($metadata.FundingSource, new $apiClients.FundingSourceApiClient())
  }
}


export interface GenderViewModel extends $models.Gender {
  genderId: string | null;
  name: string | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class GenderViewModel extends ViewModel<$models.Gender, $apiClients.GenderApiClient, string> implements $models.Gender  {
  
  constructor(initialData?: DeepPartial<$models.Gender> | null) {
    super($metadata.Gender, new $apiClients.GenderApiClient(), initialData)
  }
}
defineProps(GenderViewModel, $metadata.Gender)

export class GenderListViewModel extends ListViewModel<$models.Gender, $apiClients.GenderApiClient, GenderViewModel> {
  
  constructor() {
    super($metadata.Gender, new $apiClients.GenderApiClient())
  }
}


export interface PersonViewModel extends $models.Person {
  personId: string | null;
  regionId: string | null;
  get region(): RegionViewModel | null;
  set region(value: RegionViewModel | $models.Region | null);
  get regionsAvailable(): ViewModelCollection<RegionViewModel, $models.Region>;
  set regionsAvailable(value: (RegionViewModel | $models.Region)[] | null);
  get personTypes(): ViewModelCollection<PersonTypeViewModel, $models.PersonType>;
  set personTypes(value: (PersonTypeViewModel | $models.PersonType)[] | null);
  get encounters(): ViewModelCollection<EncounterViewModel, $models.Encounter>;
  set encounters(value: (EncounterViewModel | $models.Encounter)[] | null);
  get donations(): ViewModelCollection<DonationViewModel, $models.Donation>;
  set donations(value: (DonationViewModel | $models.Donation)[] | null);
  get disbursements(): ViewModelCollection<DisbursementViewModel, $models.Disbursement>;
  set disbursements(value: (DisbursementViewModel | $models.Disbursement)[] | null);
  get relationships(): ViewModelCollection<RelationshipViewModel, $models.Relationship>;
  set relationships(value: (RelationshipViewModel | $models.Relationship)[] | null);
  get tags(): ViewModelCollection<TagViewModel, $models.Tag>;
  set tags(value: (TagViewModel | $models.Tag)[] | null);
  firstName: string | null;
  lastName: string | null;
  email: string | null;
  phone: string | null;
  streetAddress: string | null;
  city: string | null;
  state: string | null;
  zip: string | null;
  country: string | null;
  dateOfBirth: Date | null;
  get ethnicity(): EthnicityViewModel | null;
  set ethnicity(value: EthnicityViewModel | $models.Ethnicity | null);
  ethnicityId: number | null;
  countryOfOrigin: string | null;
  cityOfOrigin: string | null;
  genderId: string | null;
  get gender(): GenderViewModel | null;
  set gender(value: GenderViewModel | $models.Gender | null);
  pointPersonId: string | null;
  get pointPerson(): PersonViewModel | null;
  set pointPerson(value: PersonViewModel | $models.Person | null);
  notes: string | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class PersonViewModel extends ViewModel<$models.Person, $apiClients.PersonApiClient, string> implements $models.Person  {
  
  
  public addToEncounters(initialData?: DeepPartial<$models.Encounter> | null) {
    return this.$addChild('encounters', initialData) as EncounterViewModel
  }
  
  
  public addToDonations(initialData?: DeepPartial<$models.Donation> | null) {
    return this.$addChild('donations', initialData) as DonationViewModel
  }
  
  
  public addToDisbursements(initialData?: DeepPartial<$models.Disbursement> | null) {
    return this.$addChild('disbursements', initialData) as DisbursementViewModel
  }
  
  
  public addToRelationships(initialData?: DeepPartial<$models.Relationship> | null) {
    return this.$addChild('relationships', initialData) as RelationshipViewModel
  }
  
  constructor(initialData?: DeepPartial<$models.Person> | null) {
    super($metadata.Person, new $apiClients.PersonApiClient(), initialData)
  }
}
defineProps(PersonViewModel, $metadata.Person)

export class PersonListViewModel extends ListViewModel<$models.Person, $apiClients.PersonApiClient, PersonViewModel> {
  
  constructor() {
    super($metadata.Person, new $apiClients.PersonApiClient())
  }
}


export interface PersonPersonTypeViewModel extends $models.PersonPersonType {
  personPersonTypeId: string | null;
  personId: string | null;
  get person(): PersonViewModel | null;
  set person(value: PersonViewModel | $models.Person | null);
  personTypeId: string | null;
  get personType(): PersonTypeViewModel | null;
  set personType(value: PersonTypeViewModel | $models.PersonType | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class PersonPersonTypeViewModel extends ViewModel<$models.PersonPersonType, $apiClients.PersonPersonTypeApiClient, string> implements $models.PersonPersonType  {
  
  constructor(initialData?: DeepPartial<$models.PersonPersonType> | null) {
    super($metadata.PersonPersonType, new $apiClients.PersonPersonTypeApiClient(), initialData)
  }
}
defineProps(PersonPersonTypeViewModel, $metadata.PersonPersonType)

export class PersonPersonTypeListViewModel extends ListViewModel<$models.PersonPersonType, $apiClients.PersonPersonTypeApiClient, PersonPersonTypeViewModel> {
  
  constructor() {
    super($metadata.PersonPersonType, new $apiClients.PersonPersonTypeApiClient())
  }
}


export interface PersonProgramFundingSourceViewModel extends $models.PersonProgramFundingSource {
  personProgramFundingSourceId: string | null;
  personId: string | null;
  get person(): PersonViewModel | null;
  set person(value: PersonViewModel | $models.Person | null);
  programId: string | null;
  get program(): ProgramViewModel | null;
  set program(value: ProgramViewModel | $models.Program | null);
  fundingSourceId: string | null;
  get fundingSource(): FundingSourceViewModel | null;
  set fundingSource(value: FundingSourceViewModel | $models.FundingSource | null);
  state: $models.ProgramState | null;
  dateEnrolled: Date | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class PersonProgramFundingSourceViewModel extends ViewModel<$models.PersonProgramFundingSource, $apiClients.PersonProgramFundingSourceApiClient, string> implements $models.PersonProgramFundingSource  {
  
  constructor(initialData?: DeepPartial<$models.PersonProgramFundingSource> | null) {
    super($metadata.PersonProgramFundingSource, new $apiClients.PersonProgramFundingSourceApiClient(), initialData)
  }
}
defineProps(PersonProgramFundingSourceViewModel, $metadata.PersonProgramFundingSource)

export class PersonProgramFundingSourceListViewModel extends ListViewModel<$models.PersonProgramFundingSource, $apiClients.PersonProgramFundingSourceApiClient, PersonProgramFundingSourceViewModel> {
  
  constructor() {
    super($metadata.PersonProgramFundingSource, new $apiClients.PersonProgramFundingSourceApiClient())
  }
}


export interface PersonRegionAccessViewModel extends $models.PersonRegionAccess {
  personRegionAccessId: string | null;
  personId: string | null;
  get person(): PersonViewModel | null;
  set person(value: PersonViewModel | $models.Person | null);
  regionId: string | null;
  get region(): RegionViewModel | null;
  set region(value: RegionViewModel | $models.Region | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class PersonRegionAccessViewModel extends ViewModel<$models.PersonRegionAccess, $apiClients.PersonRegionAccessApiClient, string> implements $models.PersonRegionAccess  {
  
  constructor(initialData?: DeepPartial<$models.PersonRegionAccess> | null) {
    super($metadata.PersonRegionAccess, new $apiClients.PersonRegionAccessApiClient(), initialData)
  }
}
defineProps(PersonRegionAccessViewModel, $metadata.PersonRegionAccess)

export class PersonRegionAccessListViewModel extends ListViewModel<$models.PersonRegionAccess, $apiClients.PersonRegionAccessApiClient, PersonRegionAccessViewModel> {
  
  constructor() {
    super($metadata.PersonRegionAccess, new $apiClients.PersonRegionAccessApiClient())
  }
}


export interface PersonTypeViewModel extends $models.PersonType {
  personTypeId: string | null;
  name: string | null;
  hasCareNeeds: boolean | null;
  hasCareAssets: boolean | null;
  isOrganization: boolean | null;
  get people(): ViewModelCollection<PersonViewModel, $models.Person>;
  set people(value: (PersonViewModel | $models.Person)[] | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class PersonTypeViewModel extends ViewModel<$models.PersonType, $apiClients.PersonTypeApiClient, string> implements $models.PersonType  {
  
  constructor(initialData?: DeepPartial<$models.PersonType> | null) {
    super($metadata.PersonType, new $apiClients.PersonTypeApiClient(), initialData)
  }
}
defineProps(PersonTypeViewModel, $metadata.PersonType)

export class PersonTypeListViewModel extends ListViewModel<$models.PersonType, $apiClients.PersonTypeApiClient, PersonTypeViewModel> {
  
  constructor() {
    super($metadata.PersonType, new $apiClients.PersonTypeApiClient())
  }
}


export interface ProgramViewModel extends $models.Program {
  programId: string | null;
  name: string | null;
  description: string | null;
  get fundingSources(): ViewModelCollection<FundingSourceViewModel, $models.FundingSource>;
  set fundingSources(value: (FundingSourceViewModel | $models.FundingSource)[] | null);
  get activities(): ViewModelCollection<ActivityViewModel, $models.Activity>;
  set activities(value: (ActivityViewModel | $models.Activity)[] | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class ProgramViewModel extends ViewModel<$models.Program, $apiClients.ProgramApiClient, string> implements $models.Program  {
  
  constructor(initialData?: DeepPartial<$models.Program> | null) {
    super($metadata.Program, new $apiClients.ProgramApiClient(), initialData)
  }
}
defineProps(ProgramViewModel, $metadata.Program)

export class ProgramListViewModel extends ListViewModel<$models.Program, $apiClients.ProgramApiClient, ProgramViewModel> {
  
  constructor() {
    super($metadata.Program, new $apiClients.ProgramApiClient())
  }
}


export interface ProgramActivityViewModel extends $models.ProgramActivity {
  programActivityId: string | null;
  programId: string | null;
  get program(): ProgramViewModel | null;
  set program(value: ProgramViewModel | $models.Program | null);
  activityId: string | null;
  get activity(): ActivityViewModel | null;
  set activity(value: ActivityViewModel | $models.Activity | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class ProgramActivityViewModel extends ViewModel<$models.ProgramActivity, $apiClients.ProgramActivityApiClient, string> implements $models.ProgramActivity  {
  
  constructor(initialData?: DeepPartial<$models.ProgramActivity> | null) {
    super($metadata.ProgramActivity, new $apiClients.ProgramActivityApiClient(), initialData)
  }
}
defineProps(ProgramActivityViewModel, $metadata.ProgramActivity)

export class ProgramActivityListViewModel extends ListViewModel<$models.ProgramActivity, $apiClients.ProgramActivityApiClient, ProgramActivityViewModel> {
  
  constructor() {
    super($metadata.ProgramActivity, new $apiClients.ProgramActivityApiClient())
  }
}


export interface ProgramFundingSourceViewModel extends $models.ProgramFundingSource {
  programFundingSourceId: string | null;
  programId: string | null;
  get program(): ProgramViewModel | null;
  set program(value: ProgramViewModel | $models.Program | null);
  fundingSourceId: string | null;
  get fundingSource(): FundingSourceViewModel | null;
  set fundingSource(value: FundingSourceViewModel | $models.FundingSource | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class ProgramFundingSourceViewModel extends ViewModel<$models.ProgramFundingSource, $apiClients.ProgramFundingSourceApiClient, string> implements $models.ProgramFundingSource  {
  
  constructor(initialData?: DeepPartial<$models.ProgramFundingSource> | null) {
    super($metadata.ProgramFundingSource, new $apiClients.ProgramFundingSourceApiClient(), initialData)
  }
}
defineProps(ProgramFundingSourceViewModel, $metadata.ProgramFundingSource)

export class ProgramFundingSourceListViewModel extends ListViewModel<$models.ProgramFundingSource, $apiClients.ProgramFundingSourceApiClient, ProgramFundingSourceViewModel> {
  
  constructor() {
    super($metadata.ProgramFundingSource, new $apiClients.ProgramFundingSourceApiClient())
  }
}


export interface RegionViewModel extends $models.Region {
  regionId: string | null;
  name: string | null;
  code: string | null;
  parentRegionId: string | null;
  get parentRegion(): RegionViewModel | null;
  set parentRegion(value: RegionViewModel | $models.Region | null);
  get children(): ViewModelCollection<RegionViewModel, $models.Region>;
  set children(value: (RegionViewModel | $models.Region)[] | null);
  get peopleWithAccess(): ViewModelCollection<PersonViewModel, $models.Person>;
  set peopleWithAccess(value: (PersonViewModel | $models.Person)[] | null);
  
  /** Returns the index of the level of this region in the hierarchy with 0 being the top */
  level: number | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class RegionViewModel extends ViewModel<$models.Region, $apiClients.RegionApiClient, string> implements $models.Region  {
  
  
  public addToPeopleWithAccess(initialData?: DeepPartial<$models.Person> | null) {
    return this.$addChild('peopleWithAccess', initialData) as PersonViewModel
  }
  
  constructor(initialData?: DeepPartial<$models.Region> | null) {
    super($metadata.Region, new $apiClients.RegionApiClient(), initialData)
  }
}
defineProps(RegionViewModel, $metadata.Region)

export class RegionListViewModel extends ListViewModel<$models.Region, $apiClients.RegionApiClient, RegionViewModel> {
  
  constructor() {
    super($metadata.Region, new $apiClients.RegionApiClient())
  }
}


export interface RelationshipViewModel extends $models.Relationship {
  relationshipId: string | null;
  personId: string | null;
  get person(): PersonViewModel | null;
  set person(value: PersonViewModel | $models.Person | null);
  relatedPersonId: string | null;
  get relatedPerson(): PersonViewModel | null;
  set relatedPerson(value: PersonViewModel | $models.Person | null);
  relationshipTypeId: string | null;
  get relationshipType(): RelationshipTypeViewModel | null;
  set relationshipType(value: RelationshipTypeViewModel | $models.RelationshipType | null);
  startDate: Date | null;
  endDate: Date | null;
  isActive: boolean | null;
  note: string | null;
  oppositeRelationshipId: string | null;
  get oppositeRelationship(): RelationshipViewModel | null;
  set oppositeRelationship(value: RelationshipViewModel | $models.Relationship | null);
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class RelationshipViewModel extends ViewModel<$models.Relationship, $apiClients.RelationshipApiClient, string> implements $models.Relationship  {
  
  constructor(initialData?: DeepPartial<$models.Relationship> | null) {
    super($metadata.Relationship, new $apiClients.RelationshipApiClient(), initialData)
  }
}
defineProps(RelationshipViewModel, $metadata.Relationship)

export class RelationshipListViewModel extends ListViewModel<$models.Relationship, $apiClients.RelationshipApiClient, RelationshipViewModel> {
  
  public get create() {
    const create = this.$apiClient.$makeCaller(
      this.$metadata.methods.create,
      (c, person: $models.Person | null, relatedPerson: $models.Person | null, relationshipTypeId: string | null) => c.create(person, relatedPerson, relationshipTypeId),
      () => ({person: null as $models.Person | null, relatedPerson: null as $models.Person | null, relationshipTypeId: null as string | null, }),
      (c, args) => c.create(args.person, args.relatedPerson, args.relationshipTypeId))
    
    Object.defineProperty(this, 'create', {value: create});
    return create
  }
  
  constructor() {
    super($metadata.Relationship, new $apiClients.RelationshipApiClient())
  }
}


export interface RelationshipTypeViewModel extends $models.RelationshipType {
  relationshipTypeId: string | null;
  name: string | null;
  oppositeRelationshipTypeId: string | null;
  get oppositeRelationshipType(): RelationshipTypeViewModel | null;
  set oppositeRelationshipType(value: RelationshipTypeViewModel | $models.RelationshipType | null);
  entityName: string | null;
  relatedEntityName: string | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class RelationshipTypeViewModel extends ViewModel<$models.RelationshipType, $apiClients.RelationshipTypeApiClient, string> implements $models.RelationshipType  {
  
  constructor(initialData?: DeepPartial<$models.RelationshipType> | null) {
    super($metadata.RelationshipType, new $apiClients.RelationshipTypeApiClient(), initialData)
  }
}
defineProps(RelationshipTypeViewModel, $metadata.RelationshipType)

export class RelationshipTypeListViewModel extends ListViewModel<$models.RelationshipType, $apiClients.RelationshipTypeApiClient, RelationshipTypeViewModel> {
  
  constructor() {
    super($metadata.RelationshipType, new $apiClients.RelationshipTypeApiClient())
  }
}


export interface RoleViewModel extends $models.Role {
  name: string | null;
  permissions: $models.Permission[] | null;
  id: string | null;
}
export class RoleViewModel extends ViewModel<$models.Role, $apiClients.RoleApiClient, string> implements $models.Role  {
  
  constructor(initialData?: DeepPartial<$models.Role> | null) {
    super($metadata.Role, new $apiClients.RoleApiClient(), initialData)
  }
}
defineProps(RoleViewModel, $metadata.Role)

export class RoleListViewModel extends ListViewModel<$models.Role, $apiClients.RoleApiClient, RoleViewModel> {
  
  constructor() {
    super($metadata.Role, new $apiClients.RoleApiClient())
  }
}


export interface TagViewModel extends $models.Tag {
  tagId: string | null;
  name: string | null;
  get modifiedBy(): UserViewModel | null;
  set modifiedBy(value: UserViewModel | $models.User | null);
  modifiedById: string | null;
  modifiedOn: Date | null;
  get createdBy(): UserViewModel | null;
  set createdBy(value: UserViewModel | $models.User | null);
  createdById: string | null;
  createdOn: Date | null;
}
export class TagViewModel extends ViewModel<$models.Tag, $apiClients.TagApiClient, string> implements $models.Tag  {
  
  constructor(initialData?: DeepPartial<$models.Tag> | null) {
    super($metadata.Tag, new $apiClients.TagApiClient(), initialData)
  }
}
defineProps(TagViewModel, $metadata.Tag)

export class TagListViewModel extends ListViewModel<$models.Tag, $apiClients.TagApiClient, TagViewModel> {
  
  constructor() {
    super($metadata.Tag, new $apiClients.TagApiClient())
  }
}


export interface TenantViewModel extends $models.Tenant {
  tenantId: string | null;
  name: string | null;
}
export class TenantViewModel extends ViewModel<$models.Tenant, $apiClients.TenantApiClient, string> implements $models.Tenant  {
  static DataSources = $models.Tenant.DataSources;
  
  constructor(initialData?: DeepPartial<$models.Tenant> | null) {
    super($metadata.Tenant, new $apiClients.TenantApiClient(), initialData)
  }
}
defineProps(TenantViewModel, $metadata.Tenant)

export class TenantListViewModel extends ListViewModel<$models.Tenant, $apiClients.TenantApiClient, TenantViewModel> {
  static DataSources = $models.Tenant.DataSources;
  
  public get create() {
    const create = this.$apiClient.$makeCaller(
      this.$metadata.methods.create,
      (c, name: string | null, adminEmail: string | null) => c.create(name, adminEmail),
      () => ({name: null as string | null, adminEmail: null as string | null, }),
      (c, args) => c.create(args.name, args.adminEmail))
    
    Object.defineProperty(this, 'create', {value: create});
    return create
  }
  
  constructor() {
    super($metadata.Tenant, new $apiClients.TenantApiClient())
  }
}


export interface UserViewModel extends $models.User {
  fullName: string | null;
  userName: string | null;
  email: string | null;
  emailConfirmed: boolean | null;
  photoHash: string | null;
  get userRoles(): ViewModelCollection<UserRoleViewModel, $models.UserRole>;
  set userRoles(value: (UserRoleViewModel | $models.UserRole)[] | null);
  roleNames: string[] | null;
  
  /** Global admins can perform some administrative actions against ALL tenants. */
  isGlobalAdmin: boolean | null;
  id: string | null;
}
export class UserViewModel extends ViewModel<$models.User, $apiClients.UserApiClient, string> implements $models.User  {
  static DataSources = $models.User.DataSources;
  
  
  public addToUserRoles(initialData?: DeepPartial<$models.UserRole> | null) {
    return this.$addChild('userRoles', initialData) as UserRoleViewModel
  }
  
  get roles(): ReadonlyArray<RoleViewModel> {
    return (this.userRoles || []).map($ => $.role!).filter($ => $)
  }
  
  public get getPhoto() {
    const getPhoto = this.$apiClient.$makeCaller(
      this.$metadata.methods.getPhoto,
      (c) => c.getPhoto(this.$primaryKey, this.photoHash),
      () => ({}),
      (c, args) => c.getPhoto(this.$primaryKey, this.photoHash))
    
    Object.defineProperty(this, 'getPhoto', {value: getPhoto});
    return getPhoto
  }
  
  public get evict() {
    const evict = this.$apiClient.$makeCaller(
      this.$metadata.methods.evict,
      (c) => c.evict(this.$primaryKey),
      () => ({}),
      (c, args) => c.evict(this.$primaryKey))
    
    Object.defineProperty(this, 'evict', {value: evict});
    return evict
  }
  
  public get setEmail() {
    const setEmail = this.$apiClient.$makeCaller(
      this.$metadata.methods.setEmail,
      (c, newEmail: string | null) => c.setEmail(this.$primaryKey, newEmail),
      () => ({newEmail: null as string | null, }),
      (c, args) => c.setEmail(this.$primaryKey, args.newEmail))
    
    Object.defineProperty(this, 'setEmail', {value: setEmail});
    return setEmail
  }
  
  public get sendEmailConfirmation() {
    const sendEmailConfirmation = this.$apiClient.$makeCaller(
      this.$metadata.methods.sendEmailConfirmation,
      (c) => c.sendEmailConfirmation(this.$primaryKey),
      () => ({}),
      (c, args) => c.sendEmailConfirmation(this.$primaryKey))
    
    Object.defineProperty(this, 'sendEmailConfirmation', {value: sendEmailConfirmation});
    return sendEmailConfirmation
  }
  
  public get setPassword() {
    const setPassword = this.$apiClient.$makeCaller(
      this.$metadata.methods.setPassword,
      (c, currentPassword: string | null, newPassword: string | null, confirmNewPassword: string | null) => c.setPassword(this.$primaryKey, currentPassword, newPassword, confirmNewPassword),
      () => ({currentPassword: null as string | null, newPassword: null as string | null, confirmNewPassword: null as string | null, }),
      (c, args) => c.setPassword(this.$primaryKey, args.currentPassword, args.newPassword, args.confirmNewPassword))
    
    Object.defineProperty(this, 'setPassword', {value: setPassword});
    return setPassword
  }
  
  constructor(initialData?: DeepPartial<$models.User> | null) {
    super($metadata.User, new $apiClients.UserApiClient(), initialData)
  }
}
defineProps(UserViewModel, $metadata.User)

export class UserListViewModel extends ListViewModel<$models.User, $apiClients.UserApiClient, UserViewModel> {
  static DataSources = $models.User.DataSources;
  
  public get inviteUser() {
    const inviteUser = this.$apiClient.$makeCaller(
      this.$metadata.methods.inviteUser,
      (c, email: string | null, role?: $models.Role | null) => c.inviteUser(email, role),
      () => ({email: null as string | null, role: null as $models.Role | null, }),
      (c, args) => c.inviteUser(args.email, args.role))
    
    Object.defineProperty(this, 'inviteUser', {value: inviteUser});
    return inviteUser
  }
  
  constructor() {
    super($metadata.User, new $apiClients.UserApiClient())
  }
}


export interface UserRoleViewModel extends $models.UserRole {
  id: string | null;
  get user(): UserViewModel | null;
  set user(value: UserViewModel | $models.User | null);
  get role(): RoleViewModel | null;
  set role(value: RoleViewModel | $models.Role | null);
  userId: string | null;
  roleId: string | null;
}
export class UserRoleViewModel extends ViewModel<$models.UserRole, $apiClients.UserRoleApiClient, string> implements $models.UserRole  {
  static DataSources = $models.UserRole.DataSources;
  
  constructor(initialData?: DeepPartial<$models.UserRole> | null) {
    super($metadata.UserRole, new $apiClients.UserRoleApiClient(), initialData)
  }
}
defineProps(UserRoleViewModel, $metadata.UserRole)

export class UserRoleListViewModel extends ListViewModel<$models.UserRole, $apiClients.UserRoleApiClient, UserRoleViewModel> {
  static DataSources = $models.UserRole.DataSources;
  
  constructor() {
    super($metadata.UserRole, new $apiClients.UserRoleApiClient())
  }
}


export class SecurityServiceViewModel extends ServiceViewModel<typeof $metadata.SecurityService, $apiClients.SecurityServiceApiClient> {
  
  public get whoAmI() {
    const whoAmI = this.$apiClient.$makeCaller(
      this.$metadata.methods.whoAmI,
      (c) => c.whoAmI(),
      () => ({}),
      (c, args) => c.whoAmI())
    
    Object.defineProperty(this, 'whoAmI', {value: whoAmI});
    return whoAmI
  }
  
  constructor() {
    super($metadata.SecurityService, new $apiClients.SecurityServiceApiClient())
  }
}


const viewModelTypeLookup = ViewModel.typeLookup = {
  Activity: ActivityViewModel,
  AuditLog: AuditLogViewModel,
  AuditLogProperty: AuditLogPropertyViewModel,
  Disbursement: DisbursementViewModel,
  Donation: DonationViewModel,
  Encounter: EncounterViewModel,
  Ethnicity: EthnicityViewModel,
  Form: FormViewModel,
  FormField: FormFieldViewModel,
  FormType: FormTypeViewModel,
  FormValue: FormValueViewModel,
  FundingSource: FundingSourceViewModel,
  Gender: GenderViewModel,
  Person: PersonViewModel,
  PersonPersonType: PersonPersonTypeViewModel,
  PersonProgramFundingSource: PersonProgramFundingSourceViewModel,
  PersonRegionAccess: PersonRegionAccessViewModel,
  PersonType: PersonTypeViewModel,
  Program: ProgramViewModel,
  ProgramActivity: ProgramActivityViewModel,
  ProgramFundingSource: ProgramFundingSourceViewModel,
  Region: RegionViewModel,
  Relationship: RelationshipViewModel,
  RelationshipType: RelationshipTypeViewModel,
  Role: RoleViewModel,
  Tag: TagViewModel,
  Tenant: TenantViewModel,
  User: UserViewModel,
  UserRole: UserRoleViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  Activity: ActivityListViewModel,
  AuditLog: AuditLogListViewModel,
  AuditLogProperty: AuditLogPropertyListViewModel,
  Disbursement: DisbursementListViewModel,
  Donation: DonationListViewModel,
  Encounter: EncounterListViewModel,
  Ethnicity: EthnicityListViewModel,
  Form: FormListViewModel,
  FormField: FormFieldListViewModel,
  FormType: FormTypeListViewModel,
  FormValue: FormValueListViewModel,
  FundingSource: FundingSourceListViewModel,
  Gender: GenderListViewModel,
  Person: PersonListViewModel,
  PersonPersonType: PersonPersonTypeListViewModel,
  PersonProgramFundingSource: PersonProgramFundingSourceListViewModel,
  PersonRegionAccess: PersonRegionAccessListViewModel,
  PersonType: PersonTypeListViewModel,
  Program: ProgramListViewModel,
  ProgramActivity: ProgramActivityListViewModel,
  ProgramFundingSource: ProgramFundingSourceListViewModel,
  Region: RegionListViewModel,
  Relationship: RelationshipListViewModel,
  RelationshipType: RelationshipTypeListViewModel,
  Role: RoleListViewModel,
  Tag: TagListViewModel,
  Tenant: TenantListViewModel,
  User: UserListViewModel,
  UserRole: UserRoleListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
  SecurityService: SecurityServiceViewModel,
}

