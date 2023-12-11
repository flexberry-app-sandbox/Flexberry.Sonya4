import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-sonya4-клиенты-l');
  this.route('i-i-s-sonya4-клиенты-e',
  { path: 'i-i-s-sonya4-клиенты-e/:id' });
  this.route('i-i-s-sonya4-клиенты-e.new',
  { path: 'i-i-s-sonya4-клиенты-e/new' });
  this.route('i-i-s-sonya4-материалы-l');
  this.route('i-i-s-sonya4-материалы-e',
  { path: 'i-i-s-sonya4-материалы-e/:id' });
  this.route('i-i-s-sonya4-материалы-e.new',
  { path: 'i-i-s-sonya4-материалы-e/new' });
  this.route('i-i-s-sonya4-поставщики-l');
  this.route('i-i-s-sonya4-поставщики-e',
  { path: 'i-i-s-sonya4-поставщики-e/:id' });
  this.route('i-i-s-sonya4-поставщики-e.new',
  { path: 'i-i-s-sonya4-поставщики-e/new' });
  this.route('i-i-s-sonya4-приход-денег-l');
  this.route('i-i-s-sonya4-приход-денег-e',
  { path: 'i-i-s-sonya4-приход-денег-e/:id' });
  this.route('i-i-s-sonya4-приход-денег-e.new',
  { path: 'i-i-s-sonya4-приход-денег-e/new' });
  this.route('i-i-s-sonya4-расход-денег-l');
  this.route('i-i-s-sonya4-расход-денег-e',
  { path: 'i-i-s-sonya4-расход-денег-e/:id' });
  this.route('i-i-s-sonya4-расход-денег-e.new',
  { path: 'i-i-s-sonya4-расход-денег-e/new' });
  this.route('i-i-s-sonya4-регистр-l');
  this.route('i-i-s-sonya4-регистр-e',
  { path: 'i-i-s-sonya4-регистр-e/:id' });
  this.route('i-i-s-sonya4-регистр-e.new',
  { path: 'i-i-s-sonya4-регистр-e/new' });
  this.route('i-i-s-sonya4-товары-l');
  this.route('i-i-s-sonya4-товары-e',
  { path: 'i-i-s-sonya4-товары-e/:id' });
  this.route('i-i-s-sonya4-товары-e.new',
  { path: 'i-i-s-sonya4-товары-e/new' });
  this.route('i-i-s-sonya4-услуги-l');
  this.route('i-i-s-sonya4-услуги-e',
  { path: 'i-i-s-sonya4-услуги-e/:id' });
  this.route('i-i-s-sonya4-услуги-e.new',
  { path: 'i-i-s-sonya4-услуги-e/new' });
});

export default Router;
