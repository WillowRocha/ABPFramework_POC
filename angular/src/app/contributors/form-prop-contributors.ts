import { eIdentityComponents, IdentityCreateFormPropContributors } from '@abp/ng.identity';
import { IdentityUserDto } from '@abp/ng.identity/proxy';
import { ePropType, FormProp, FormPropList } from '@abp/ng.theme.shared/extensions';
import { Validators } from '@angular/forms';

const birthdayProp = new FormProp<IdentityUserDto>({
  type: ePropType.Date,
  name: 'birthday',
  displayName: 'AbpIdentity::Birthday',
  validators: () => [Validators.required],
});

export function birthdayPropContributor(propList: FormPropList<IdentityUserDto>) {
  propList.addByIndex(birthdayProp, 4);
}

export const identityCreateFormPropContributors: IdentityCreateFormPropContributors = {
  [eIdentityComponents.Users]: [birthdayPropContributor],
};

export const identityEditFormPropContributors = identityCreateFormPropContributors;
