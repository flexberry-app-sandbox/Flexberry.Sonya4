import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-sonya4-услуги', 'Unit | Serializer | i-i-s-sonya4-услуги', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-sonya4-услуги',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-sonya4-банк',
    'transform:i-i-s-sonya4-единицы',
    'transform:i-i-s-sonya4-тип-прихода',

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
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
