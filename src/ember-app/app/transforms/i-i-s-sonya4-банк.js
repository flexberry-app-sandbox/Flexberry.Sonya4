import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import БанкEnum from '../enums/i-i-s-sonya4-банк';

export default FlexberryEnum.extend({
  enum: БанкEnum,
  sourceType: 'IIS.Sonya4.Банк'
});
