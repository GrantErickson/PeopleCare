import * as metadata from './metadata.g'
import { convertToModel, mapToModel, reactiveDataSource } from 'coalesce-vue/lib/model'
import type { Model, DataSource } from 'coalesce-vue/lib/model'

export enum AuditEntryState {
  EntityAdded = 0,
  EntityDeleted = 1,
  EntityModified = 2,
}


export enum FormFieldType {
  Number = 1,
  ShortText = 2,
  LongText = 3,
  Selection = 4,
}


export enum Permission {
  
  /** Modify application configuration and other administrative functions excluding user/role management. */
  Admin = 1,
  
  /** Add and modify users accounts and their assigned roles. Edit roles and their permissions. */
  UserAdmin = 2,
  ViewAuditLogs = 3,
}


export enum ProgramState {
  Enrolled = 0,
  Completed = 1,
  Withdrawn = 2,
}


export interface Activity extends Model<typeof metadata.Activity> {
  activityId: string | null
  name: string | null
  description: string | null
  date: Date | null
  durationInMinutes: number | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Activity {
  
  /** Mutates the input object and its descendents into a valid Activity implementation. */
  static convert(data?: Partial<Activity>): Activity {
    return convertToModel(data || {}, metadata.Activity) 
  }
  
  /** Maps the input object and its descendents to a new, valid Activity implementation. */
  static map(data?: Partial<Activity>): Activity {
    return mapToModel(data || {}, metadata.Activity) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Activity; }
  
  /** Instantiate a new Activity, optionally basing it on the given data. */
  constructor(data?: Partial<Activity> | {[k: string]: any}) {
    Object.assign(this, Activity.map(data || {}));
  }
}


export interface AuditLog extends Model<typeof metadata.AuditLog> {
  userId: string | null
  user: User | null
  id: number | null
  type: string | null
  keyValue: string | null
  description: string | null
  state: AuditEntryState | null
  date: Date | null
  properties: AuditLogProperty[] | null
  clientIp: string | null
  referrer: string | null
  endpoint: string | null
}
export class AuditLog {
  
  /** Mutates the input object and its descendents into a valid AuditLog implementation. */
  static convert(data?: Partial<AuditLog>): AuditLog {
    return convertToModel(data || {}, metadata.AuditLog) 
  }
  
  /** Maps the input object and its descendents to a new, valid AuditLog implementation. */
  static map(data?: Partial<AuditLog>): AuditLog {
    return mapToModel(data || {}, metadata.AuditLog) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.AuditLog; }
  
  /** Instantiate a new AuditLog, optionally basing it on the given data. */
  constructor(data?: Partial<AuditLog> | {[k: string]: any}) {
    Object.assign(this, AuditLog.map(data || {}));
  }
}
export namespace AuditLog {
  export namespace DataSources {
    
    export class TenantedDataSource implements DataSource<typeof metadata.AuditLog.dataSources.tenantedDataSource> {
      readonly $metadata = metadata.AuditLog.dataSources.tenantedDataSource
    }
  }
}


export interface AuditLogProperty extends Model<typeof metadata.AuditLogProperty> {
  id: number | null
  parentId: number | null
  propertyName: string | null
  oldValue: string | null
  oldValueDescription: string | null
  newValue: string | null
  newValueDescription: string | null
}
export class AuditLogProperty {
  
  /** Mutates the input object and its descendents into a valid AuditLogProperty implementation. */
  static convert(data?: Partial<AuditLogProperty>): AuditLogProperty {
    return convertToModel(data || {}, metadata.AuditLogProperty) 
  }
  
  /** Maps the input object and its descendents to a new, valid AuditLogProperty implementation. */
  static map(data?: Partial<AuditLogProperty>): AuditLogProperty {
    return mapToModel(data || {}, metadata.AuditLogProperty) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.AuditLogProperty; }
  
  /** Instantiate a new AuditLogProperty, optionally basing it on the given data. */
  constructor(data?: Partial<AuditLogProperty> | {[k: string]: any}) {
    Object.assign(this, AuditLogProperty.map(data || {}));
  }
}


export interface Disbursement extends Model<typeof metadata.Disbursement> {
  disbursementId: string | null
  personId: string | null
  person: Person | null
  donationId: string | null
  donation: Donation | null
  regionId: string | null
  region: Region | null
  description: string | null
  date: Date | null
  value: number | null
  quantity: number | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Disbursement {
  
  /** Mutates the input object and its descendents into a valid Disbursement implementation. */
  static convert(data?: Partial<Disbursement>): Disbursement {
    return convertToModel(data || {}, metadata.Disbursement) 
  }
  
  /** Maps the input object and its descendents to a new, valid Disbursement implementation. */
  static map(data?: Partial<Disbursement>): Disbursement {
    return mapToModel(data || {}, metadata.Disbursement) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Disbursement; }
  
  /** Instantiate a new Disbursement, optionally basing it on the given data. */
  constructor(data?: Partial<Disbursement> | {[k: string]: any}) {
    Object.assign(this, Disbursement.map(data || {}));
  }
}


export interface Donation extends Model<typeof metadata.Donation> {
  donationId: string | null
  personId: string | null
  person: Person | null
  regionId: string | null
  region: Region | null
  description: string | null
  isInKind: boolean | null
  value: number | null
  quantity: number | null
  date: Date | null
  disbursements: Disbursement[] | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Donation {
  
  /** Mutates the input object and its descendents into a valid Donation implementation. */
  static convert(data?: Partial<Donation>): Donation {
    return convertToModel(data || {}, metadata.Donation) 
  }
  
  /** Maps the input object and its descendents to a new, valid Donation implementation. */
  static map(data?: Partial<Donation>): Donation {
    return mapToModel(data || {}, metadata.Donation) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Donation; }
  
  /** Instantiate a new Donation, optionally basing it on the given data. */
  constructor(data?: Partial<Donation> | {[k: string]: any}) {
    Object.assign(this, Donation.map(data || {}));
  }
}


export interface Encounter extends Model<typeof metadata.Encounter> {
  encounterId: string | null
  personId: string | null
  person: Person | null
  contactedById: string | null
  contactedBy: Person | null
  regionId: string | null
  region: Region | null
  encounterTypeId: string | null
  encounterType: EncounterType | null
  notes: string | null
  location: string | null
  date: Date | null
  durationInMinutes: number | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Encounter {
  
  /** Mutates the input object and its descendents into a valid Encounter implementation. */
  static convert(data?: Partial<Encounter>): Encounter {
    return convertToModel(data || {}, metadata.Encounter) 
  }
  
  /** Maps the input object and its descendents to a new, valid Encounter implementation. */
  static map(data?: Partial<Encounter>): Encounter {
    return mapToModel(data || {}, metadata.Encounter) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Encounter; }
  
  /** Instantiate a new Encounter, optionally basing it on the given data. */
  constructor(data?: Partial<Encounter> | {[k: string]: any}) {
    Object.assign(this, Encounter.map(data || {}));
  }
}


export interface Ethnicity extends Model<typeof metadata.Ethnicity> {
  ethnicityId: string | null
  name: string | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Ethnicity {
  
  /** Mutates the input object and its descendents into a valid Ethnicity implementation. */
  static convert(data?: Partial<Ethnicity>): Ethnicity {
    return convertToModel(data || {}, metadata.Ethnicity) 
  }
  
  /** Maps the input object and its descendents to a new, valid Ethnicity implementation. */
  static map(data?: Partial<Ethnicity>): Ethnicity {
    return mapToModel(data || {}, metadata.Ethnicity) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Ethnicity; }
  
  /** Instantiate a new Ethnicity, optionally basing it on the given data. */
  constructor(data?: Partial<Ethnicity> | {[k: string]: any}) {
    Object.assign(this, Ethnicity.map(data || {}));
  }
}


export interface Form extends Model<typeof metadata.Form> {
  formId: string | null
  formTypeId: string | null
  formType: FormType | null
  date: Date | null
  formValues: FormValue[] | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Form {
  
  /** Mutates the input object and its descendents into a valid Form implementation. */
  static convert(data?: Partial<Form>): Form {
    return convertToModel(data || {}, metadata.Form) 
  }
  
  /** Maps the input object and its descendents to a new, valid Form implementation. */
  static map(data?: Partial<Form>): Form {
    return mapToModel(data || {}, metadata.Form) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Form; }
  
  /** Instantiate a new Form, optionally basing it on the given data. */
  constructor(data?: Partial<Form> | {[k: string]: any}) {
    Object.assign(this, Form.map(data || {}));
  }
}


export interface FormField extends Model<typeof metadata.FormField> {
  formFieldId: string | null
  name: string | null
  description: string | null
  type: FormFieldType | null
  validValues: string | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class FormField {
  
  /** Mutates the input object and its descendents into a valid FormField implementation. */
  static convert(data?: Partial<FormField>): FormField {
    return convertToModel(data || {}, metadata.FormField) 
  }
  
  /** Maps the input object and its descendents to a new, valid FormField implementation. */
  static map(data?: Partial<FormField>): FormField {
    return mapToModel(data || {}, metadata.FormField) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.FormField; }
  
  /** Instantiate a new FormField, optionally basing it on the given data. */
  constructor(data?: Partial<FormField> | {[k: string]: any}) {
    Object.assign(this, FormField.map(data || {}));
  }
}


export interface FormType extends Model<typeof metadata.FormType> {
  formTypeId: string | null
  name: string | null
  forms: Form[] | null
  fields: FormField[] | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class FormType {
  
  /** Mutates the input object and its descendents into a valid FormType implementation. */
  static convert(data?: Partial<FormType>): FormType {
    return convertToModel(data || {}, metadata.FormType) 
  }
  
  /** Maps the input object and its descendents to a new, valid FormType implementation. */
  static map(data?: Partial<FormType>): FormType {
    return mapToModel(data || {}, metadata.FormType) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.FormType; }
  
  /** Instantiate a new FormType, optionally basing it on the given data. */
  constructor(data?: Partial<FormType> | {[k: string]: any}) {
    Object.assign(this, FormType.map(data || {}));
  }
}


export interface FormValue extends Model<typeof metadata.FormValue> {
  formValueId: string | null
  formId: string | null
  form: Form | null
  formFieldId: string | null
  formField: FormField | null
  value: string | null
}
export class FormValue {
  
  /** Mutates the input object and its descendents into a valid FormValue implementation. */
  static convert(data?: Partial<FormValue>): FormValue {
    return convertToModel(data || {}, metadata.FormValue) 
  }
  
  /** Maps the input object and its descendents to a new, valid FormValue implementation. */
  static map(data?: Partial<FormValue>): FormValue {
    return mapToModel(data || {}, metadata.FormValue) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.FormValue; }
  
  /** Instantiate a new FormValue, optionally basing it on the given data. */
  constructor(data?: Partial<FormValue> | {[k: string]: any}) {
    Object.assign(this, FormValue.map(data || {}));
  }
}


export interface FundingSource extends Model<typeof metadata.FundingSource> {
  fundingSourceId: string | null
  name: string | null
  programs: Program[] | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class FundingSource {
  
  /** Mutates the input object and its descendents into a valid FundingSource implementation. */
  static convert(data?: Partial<FundingSource>): FundingSource {
    return convertToModel(data || {}, metadata.FundingSource) 
  }
  
  /** Maps the input object and its descendents to a new, valid FundingSource implementation. */
  static map(data?: Partial<FundingSource>): FundingSource {
    return mapToModel(data || {}, metadata.FundingSource) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.FundingSource; }
  
  /** Instantiate a new FundingSource, optionally basing it on the given data. */
  constructor(data?: Partial<FundingSource> | {[k: string]: any}) {
    Object.assign(this, FundingSource.map(data || {}));
  }
}


export interface Gender extends Model<typeof metadata.Gender> {
  genderId: string | null
  name: string | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Gender {
  
  /** Mutates the input object and its descendents into a valid Gender implementation. */
  static convert(data?: Partial<Gender>): Gender {
    return convertToModel(data || {}, metadata.Gender) 
  }
  
  /** Maps the input object and its descendents to a new, valid Gender implementation. */
  static map(data?: Partial<Gender>): Gender {
    return mapToModel(data || {}, metadata.Gender) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Gender; }
  
  /** Instantiate a new Gender, optionally basing it on the given data. */
  constructor(data?: Partial<Gender> | {[k: string]: any}) {
    Object.assign(this, Gender.map(data || {}));
  }
}


export interface Person extends Model<typeof metadata.Person> {
  personId: string | null
  regionId: string | null
  region: Region | null
  regionsAvailable: Region[] | null
  personTypes: PersonType[] | null
  encounters: Encounter[] | null
  donations: Donation[] | null
  disbursements: Disbursement[] | null
  relationships: Relationship[] | null
  tags: Tag[] | null
  firstName: string | null
  lastName: string | null
  email: string | null
  phone: string | null
  streetAddress: string | null
  city: string | null
  state: string | null
  zip: string | null
  country: string | null
  dateOfBirth: Date | null
  ethnicity: Ethnicity | null
  ethnicityId: number | null
  countryOfOrigin: string | null
  cityOfOrigin: string | null
  genderId: string | null
  gender: Gender | null
  pointPersonId: string | null
  pointPerson: Person | null
  notes: string | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Person {
  
  /** Mutates the input object and its descendents into a valid Person implementation. */
  static convert(data?: Partial<Person>): Person {
    return convertToModel(data || {}, metadata.Person) 
  }
  
  /** Maps the input object and its descendents to a new, valid Person implementation. */
  static map(data?: Partial<Person>): Person {
    return mapToModel(data || {}, metadata.Person) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Person; }
  
  /** Instantiate a new Person, optionally basing it on the given data. */
  constructor(data?: Partial<Person> | {[k: string]: any}) {
    Object.assign(this, Person.map(data || {}));
  }
}


export interface PersonPersonType extends Model<typeof metadata.PersonPersonType> {
  personPersonTypeId: string | null
  personId: string | null
  person: Person | null
  personTypeId: string | null
  personType: PersonType | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class PersonPersonType {
  
  /** Mutates the input object and its descendents into a valid PersonPersonType implementation. */
  static convert(data?: Partial<PersonPersonType>): PersonPersonType {
    return convertToModel(data || {}, metadata.PersonPersonType) 
  }
  
  /** Maps the input object and its descendents to a new, valid PersonPersonType implementation. */
  static map(data?: Partial<PersonPersonType>): PersonPersonType {
    return mapToModel(data || {}, metadata.PersonPersonType) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.PersonPersonType; }
  
  /** Instantiate a new PersonPersonType, optionally basing it on the given data. */
  constructor(data?: Partial<PersonPersonType> | {[k: string]: any}) {
    Object.assign(this, PersonPersonType.map(data || {}));
  }
}


export interface PersonProgramFundingSource extends Model<typeof metadata.PersonProgramFundingSource> {
  personProgramFundingSourceId: string | null
  personId: string | null
  person: Person | null
  programId: string | null
  program: Program | null
  fundingSourceId: string | null
  fundingSource: FundingSource | null
  state: ProgramState | null
  dateEnrolled: Date | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class PersonProgramFundingSource {
  
  /** Mutates the input object and its descendents into a valid PersonProgramFundingSource implementation. */
  static convert(data?: Partial<PersonProgramFundingSource>): PersonProgramFundingSource {
    return convertToModel(data || {}, metadata.PersonProgramFundingSource) 
  }
  
  /** Maps the input object and its descendents to a new, valid PersonProgramFundingSource implementation. */
  static map(data?: Partial<PersonProgramFundingSource>): PersonProgramFundingSource {
    return mapToModel(data || {}, metadata.PersonProgramFundingSource) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.PersonProgramFundingSource; }
  
  /** Instantiate a new PersonProgramFundingSource, optionally basing it on the given data. */
  constructor(data?: Partial<PersonProgramFundingSource> | {[k: string]: any}) {
    Object.assign(this, PersonProgramFundingSource.map(data || {}));
  }
}


export interface PersonRegionAccess extends Model<typeof metadata.PersonRegionAccess> {
  personRegionAccessId: string | null
  personId: string | null
  person: Person | null
  regionId: string | null
  region: Region | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class PersonRegionAccess {
  
  /** Mutates the input object and its descendents into a valid PersonRegionAccess implementation. */
  static convert(data?: Partial<PersonRegionAccess>): PersonRegionAccess {
    return convertToModel(data || {}, metadata.PersonRegionAccess) 
  }
  
  /** Maps the input object and its descendents to a new, valid PersonRegionAccess implementation. */
  static map(data?: Partial<PersonRegionAccess>): PersonRegionAccess {
    return mapToModel(data || {}, metadata.PersonRegionAccess) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.PersonRegionAccess; }
  
  /** Instantiate a new PersonRegionAccess, optionally basing it on the given data. */
  constructor(data?: Partial<PersonRegionAccess> | {[k: string]: any}) {
    Object.assign(this, PersonRegionAccess.map(data || {}));
  }
}


export interface PersonType extends Model<typeof metadata.PersonType> {
  personTypeId: string | null
  name: string | null
  hasCareNeeds: boolean | null
  hasCareAssets: boolean | null
  isOrganization: boolean | null
  people: Person[] | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class PersonType {
  
  /** Mutates the input object and its descendents into a valid PersonType implementation. */
  static convert(data?: Partial<PersonType>): PersonType {
    return convertToModel(data || {}, metadata.PersonType) 
  }
  
  /** Maps the input object and its descendents to a new, valid PersonType implementation. */
  static map(data?: Partial<PersonType>): PersonType {
    return mapToModel(data || {}, metadata.PersonType) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.PersonType; }
  
  /** Instantiate a new PersonType, optionally basing it on the given data. */
  constructor(data?: Partial<PersonType> | {[k: string]: any}) {
    Object.assign(this, PersonType.map(data || {}));
  }
}


export interface Program extends Model<typeof metadata.Program> {
  programId: string | null
  name: string | null
  description: string | null
  fundingSources: FundingSource[] | null
  activities: Activity[] | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Program {
  
  /** Mutates the input object and its descendents into a valid Program implementation. */
  static convert(data?: Partial<Program>): Program {
    return convertToModel(data || {}, metadata.Program) 
  }
  
  /** Maps the input object and its descendents to a new, valid Program implementation. */
  static map(data?: Partial<Program>): Program {
    return mapToModel(data || {}, metadata.Program) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Program; }
  
  /** Instantiate a new Program, optionally basing it on the given data. */
  constructor(data?: Partial<Program> | {[k: string]: any}) {
    Object.assign(this, Program.map(data || {}));
  }
}


export interface ProgramActivity extends Model<typeof metadata.ProgramActivity> {
  programActivityId: string | null
  programId: string | null
  program: Program | null
  activityId: string | null
  activity: Activity | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class ProgramActivity {
  
  /** Mutates the input object and its descendents into a valid ProgramActivity implementation. */
  static convert(data?: Partial<ProgramActivity>): ProgramActivity {
    return convertToModel(data || {}, metadata.ProgramActivity) 
  }
  
  /** Maps the input object and its descendents to a new, valid ProgramActivity implementation. */
  static map(data?: Partial<ProgramActivity>): ProgramActivity {
    return mapToModel(data || {}, metadata.ProgramActivity) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.ProgramActivity; }
  
  /** Instantiate a new ProgramActivity, optionally basing it on the given data. */
  constructor(data?: Partial<ProgramActivity> | {[k: string]: any}) {
    Object.assign(this, ProgramActivity.map(data || {}));
  }
}


export interface ProgramFundingSource extends Model<typeof metadata.ProgramFundingSource> {
  programFundingSourceId: string | null
  programId: string | null
  program: Program | null
  fundingSourceId: string | null
  fundingSource: FundingSource | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class ProgramFundingSource {
  
  /** Mutates the input object and its descendents into a valid ProgramFundingSource implementation. */
  static convert(data?: Partial<ProgramFundingSource>): ProgramFundingSource {
    return convertToModel(data || {}, metadata.ProgramFundingSource) 
  }
  
  /** Maps the input object and its descendents to a new, valid ProgramFundingSource implementation. */
  static map(data?: Partial<ProgramFundingSource>): ProgramFundingSource {
    return mapToModel(data || {}, metadata.ProgramFundingSource) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.ProgramFundingSource; }
  
  /** Instantiate a new ProgramFundingSource, optionally basing it on the given data. */
  constructor(data?: Partial<ProgramFundingSource> | {[k: string]: any}) {
    Object.assign(this, ProgramFundingSource.map(data || {}));
  }
}


export interface Region extends Model<typeof metadata.Region> {
  regionId: string | null
  name: string | null
  code: string | null
  parentRegionId: string | null
  parentRegion: Region | null
  children: Region[] | null
  peopleWithAccess: Person[] | null
  
  /** Returns the index of the level of this region in the hierarchy with 0 being the top */
  level: number | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Region {
  
  /** Mutates the input object and its descendents into a valid Region implementation. */
  static convert(data?: Partial<Region>): Region {
    return convertToModel(data || {}, metadata.Region) 
  }
  
  /** Maps the input object and its descendents to a new, valid Region implementation. */
  static map(data?: Partial<Region>): Region {
    return mapToModel(data || {}, metadata.Region) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Region; }
  
  /** Instantiate a new Region, optionally basing it on the given data. */
  constructor(data?: Partial<Region> | {[k: string]: any}) {
    Object.assign(this, Region.map(data || {}));
  }
}


export interface Relationship extends Model<typeof metadata.Relationship> {
  relationshipId: string | null
  personId: string | null
  person: Person | null
  relatedPersonId: string | null
  relatedPerson: Person | null
  relationshipTypeId: string | null
  relationshipType: RelationshipType | null
  startDate: Date | null
  endDate: Date | null
  isActive: boolean | null
  note: string | null
  oppositeRelationshipId: string | null
  oppositeRelationship: Relationship | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Relationship {
  
  /** Mutates the input object and its descendents into a valid Relationship implementation. */
  static convert(data?: Partial<Relationship>): Relationship {
    return convertToModel(data || {}, metadata.Relationship) 
  }
  
  /** Maps the input object and its descendents to a new, valid Relationship implementation. */
  static map(data?: Partial<Relationship>): Relationship {
    return mapToModel(data || {}, metadata.Relationship) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Relationship; }
  
  /** Instantiate a new Relationship, optionally basing it on the given data. */
  constructor(data?: Partial<Relationship> | {[k: string]: any}) {
    Object.assign(this, Relationship.map(data || {}));
  }
}


export interface RelationshipType extends Model<typeof metadata.RelationshipType> {
  relationshipTypeId: string | null
  name: string | null
  oppositeRelationshipTypeId: string | null
  oppositeRelationshipType: RelationshipType | null
  entityName: string | null
  relatedEntityName: string | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class RelationshipType {
  
  /** Mutates the input object and its descendents into a valid RelationshipType implementation. */
  static convert(data?: Partial<RelationshipType>): RelationshipType {
    return convertToModel(data || {}, metadata.RelationshipType) 
  }
  
  /** Maps the input object and its descendents to a new, valid RelationshipType implementation. */
  static map(data?: Partial<RelationshipType>): RelationshipType {
    return mapToModel(data || {}, metadata.RelationshipType) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.RelationshipType; }
  
  /** Instantiate a new RelationshipType, optionally basing it on the given data. */
  constructor(data?: Partial<RelationshipType> | {[k: string]: any}) {
    Object.assign(this, RelationshipType.map(data || {}));
  }
}


export interface Role extends Model<typeof metadata.Role> {
  name: string | null
  permissions: Permission[] | null
  id: string | null
}
export class Role {
  
  /** Mutates the input object and its descendents into a valid Role implementation. */
  static convert(data?: Partial<Role>): Role {
    return convertToModel(data || {}, metadata.Role) 
  }
  
  /** Maps the input object and its descendents to a new, valid Role implementation. */
  static map(data?: Partial<Role>): Role {
    return mapToModel(data || {}, metadata.Role) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Role; }
  
  /** Instantiate a new Role, optionally basing it on the given data. */
  constructor(data?: Partial<Role> | {[k: string]: any}) {
    Object.assign(this, Role.map(data || {}));
  }
}


export interface Tag extends Model<typeof metadata.Tag> {
  tagId: string | null
  name: string | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class Tag {
  
  /** Mutates the input object and its descendents into a valid Tag implementation. */
  static convert(data?: Partial<Tag>): Tag {
    return convertToModel(data || {}, metadata.Tag) 
  }
  
  /** Maps the input object and its descendents to a new, valid Tag implementation. */
  static map(data?: Partial<Tag>): Tag {
    return mapToModel(data || {}, metadata.Tag) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Tag; }
  
  /** Instantiate a new Tag, optionally basing it on the given data. */
  constructor(data?: Partial<Tag> | {[k: string]: any}) {
    Object.assign(this, Tag.map(data || {}));
  }
}


export interface Tenant extends Model<typeof metadata.Tenant> {
  tenantId: string | null
  name: string | null
}
export class Tenant {
  
  /** Mutates the input object and its descendents into a valid Tenant implementation. */
  static convert(data?: Partial<Tenant>): Tenant {
    return convertToModel(data || {}, metadata.Tenant) 
  }
  
  /** Maps the input object and its descendents to a new, valid Tenant implementation. */
  static map(data?: Partial<Tenant>): Tenant {
    return mapToModel(data || {}, metadata.Tenant) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Tenant; }
  
  /** Instantiate a new Tenant, optionally basing it on the given data. */
  constructor(data?: Partial<Tenant> | {[k: string]: any}) {
    Object.assign(this, Tenant.map(data || {}));
  }
}
export namespace Tenant {
  export namespace DataSources {
    
    export class DefaultSource implements DataSource<typeof metadata.Tenant.dataSources.defaultSource> {
      readonly $metadata = metadata.Tenant.dataSources.defaultSource
    }
    
    export class GlobalAdminSource implements DataSource<typeof metadata.Tenant.dataSources.globalAdminSource> {
      readonly $metadata = metadata.Tenant.dataSources.globalAdminSource
    }
  }
}


export interface User extends Model<typeof metadata.User> {
  fullName: string | null
  userName: string | null
  email: string | null
  emailConfirmed: boolean | null
  photoHash: string | null
  userRoles: UserRole[] | null
  roleNames: string[] | null
  
  /** Global admins can perform some administrative actions against ALL tenants. */
  isGlobalAdmin: boolean | null
  id: string | null
}
export class User {
  
  /** Mutates the input object and its descendents into a valid User implementation. */
  static convert(data?: Partial<User>): User {
    return convertToModel(data || {}, metadata.User) 
  }
  
  /** Maps the input object and its descendents to a new, valid User implementation. */
  static map(data?: Partial<User>): User {
    return mapToModel(data || {}, metadata.User) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.User; }
  
  /** Instantiate a new User, optionally basing it on the given data. */
  constructor(data?: Partial<User> | {[k: string]: any}) {
    Object.assign(this, User.map(data || {}));
  }
}
export namespace User {
  export namespace DataSources {
    
    export class DefaultSource implements DataSource<typeof metadata.User.dataSources.defaultSource> {
      readonly $metadata = metadata.User.dataSources.defaultSource
    }
  }
}


export interface UserRole extends Model<typeof metadata.UserRole> {
  id: string | null
  user: User | null
  role: Role | null
  userId: string | null
  roleId: string | null
}
export class UserRole {
  
  /** Mutates the input object and its descendents into a valid UserRole implementation. */
  static convert(data?: Partial<UserRole>): UserRole {
    return convertToModel(data || {}, metadata.UserRole) 
  }
  
  /** Maps the input object and its descendents to a new, valid UserRole implementation. */
  static map(data?: Partial<UserRole>): UserRole {
    return mapToModel(data || {}, metadata.UserRole) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.UserRole; }
  
  /** Instantiate a new UserRole, optionally basing it on the given data. */
  constructor(data?: Partial<UserRole> | {[k: string]: any}) {
    Object.assign(this, UserRole.map(data || {}));
  }
}
export namespace UserRole {
  export namespace DataSources {
    
    export class DefaultSource implements DataSource<typeof metadata.UserRole.dataSources.defaultSource> {
      readonly $metadata = metadata.UserRole.dataSources.defaultSource
    }
  }
}


export interface EncounterType extends Model<typeof metadata.EncounterType> {
  encounterTypeId: string | null
  name: string | null
  modifiedBy: User | null
  modifiedById: string | null
  modifiedOn: Date | null
  createdBy: User | null
  createdById: string | null
  createdOn: Date | null
}
export class EncounterType {
  
  /** Mutates the input object and its descendents into a valid EncounterType implementation. */
  static convert(data?: Partial<EncounterType>): EncounterType {
    return convertToModel(data || {}, metadata.EncounterType) 
  }
  
  /** Maps the input object and its descendents to a new, valid EncounterType implementation. */
  static map(data?: Partial<EncounterType>): EncounterType {
    return mapToModel(data || {}, metadata.EncounterType) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.EncounterType; }
  
  /** Instantiate a new EncounterType, optionally basing it on the given data. */
  constructor(data?: Partial<EncounterType> | {[k: string]: any}) {
    Object.assign(this, EncounterType.map(data || {}));
  }
}


export interface UserInfo extends Model<typeof metadata.UserInfo> {
  id: string | null
  userName: string | null
  email: string | null
  fullName: string | null
  roles: string[] | null
  permissions: string[] | null
  tenantId: string | null
  tenantName: string | null
}
export class UserInfo {
  
  /** Mutates the input object and its descendents into a valid UserInfo implementation. */
  static convert(data?: Partial<UserInfo>): UserInfo {
    return convertToModel(data || {}, metadata.UserInfo) 
  }
  
  /** Maps the input object and its descendents to a new, valid UserInfo implementation. */
  static map(data?: Partial<UserInfo>): UserInfo {
    return mapToModel(data || {}, metadata.UserInfo) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.UserInfo; }
  
  /** Instantiate a new UserInfo, optionally basing it on the given data. */
  constructor(data?: Partial<UserInfo> | {[k: string]: any}) {
    Object.assign(this, UserInfo.map(data || {}));
  }
}


declare module "coalesce-vue/lib/model" {
  interface EnumTypeLookup {
    AuditEntryState: AuditEntryState
    FormFieldType: FormFieldType
    Permission: Permission
    ProgramState: ProgramState
  }
  interface ModelTypeLookup {
    Activity: Activity
    AuditLog: AuditLog
    AuditLogProperty: AuditLogProperty
    Disbursement: Disbursement
    Donation: Donation
    Encounter: Encounter
    EncounterType: EncounterType
    Ethnicity: Ethnicity
    Form: Form
    FormField: FormField
    FormType: FormType
    FormValue: FormValue
    FundingSource: FundingSource
    Gender: Gender
    Person: Person
    PersonPersonType: PersonPersonType
    PersonProgramFundingSource: PersonProgramFundingSource
    PersonRegionAccess: PersonRegionAccess
    PersonType: PersonType
    Program: Program
    ProgramActivity: ProgramActivity
    ProgramFundingSource: ProgramFundingSource
    Region: Region
    Relationship: Relationship
    RelationshipType: RelationshipType
    Role: Role
    Tag: Tag
    Tenant: Tenant
    User: User
    UserInfo: UserInfo
    UserRole: UserRole
  }
}
