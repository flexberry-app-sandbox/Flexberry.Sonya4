import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import ТипПриходаEnum from '../enums/i-i-s-sonya4-тип-прихода';

export default FlexberryEnum.extend({
  enum: ТипПриходаEnum,
  sourceType: 'IIS.Sonya4.ТипПрихода'
});
