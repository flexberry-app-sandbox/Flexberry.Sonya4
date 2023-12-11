import { Serializer as СоставУслугиSerializer } from
  '../mixins/regenerated/serializers/i-i-s-sonya4-состав-услуги';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(СоставУслугиSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
