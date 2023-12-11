import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  количество: DS.attr('number'),
  приходДенег: DS.belongsTo('i-i-s-sonya4-приход-денег', { inverse: 'составУслуги', async: false })
});

export let ValidationRules = {
  количество: {
    descriptionKey: 'models.i-i-s-sonya4-состав-услуги.validations.количество.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  приходДенег: {
    descriptionKey: 'models.i-i-s-sonya4-состав-услуги.validations.приходДенег.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('СоставУслугиE', 'i-i-s-sonya4-состав-услуги', {
    количество: attr('Количество', { index: 0 })
  });
};
