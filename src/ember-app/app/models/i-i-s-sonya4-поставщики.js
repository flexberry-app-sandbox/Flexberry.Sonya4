import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as ПоставщикиMixin
} from '../mixins/regenerated/models/i-i-s-sonya4-поставщики';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(ПоставщикиMixin, Validations, {
});

defineProjections(Model);

export default Model;
