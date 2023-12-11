import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-sonya4-материалы', 'Unit | Model | i-i-s-sonya4-материалы', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-sonya4-клиенты',
    'model:i-i-s-sonya4-материалы',
    'model:i-i-s-sonya4-поставщики',
    'model:i-i-s-sonya4-приход-денег',
    'model:i-i-s-sonya4-расход-денег',
    'model:i-i-s-sonya4-регистр',
    'model:i-i-s-sonya4-состав-материалы',
    'model:i-i-s-sonya4-состав-товара',
    'model:i-i-s-sonya4-состав-товары',
    'model:i-i-s-sonya4-состав-услуги',
    'model:i-i-s-sonya4-товары',
    'model:i-i-s-sonya4-услуги',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
