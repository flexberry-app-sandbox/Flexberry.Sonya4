import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

import IISSonya4КлиентыLForm from './forms/i-i-s-sonya4-клиенты-l';
import IISSonya4МатериалыLForm from './forms/i-i-s-sonya4-материалы-l';
import IISSonya4ПоставщикиLForm from './forms/i-i-s-sonya4-поставщики-l';
import IISSonya4ПриходДенегLForm from './forms/i-i-s-sonya4-приход-денег-l';
import IISSonya4РасходДенегLForm from './forms/i-i-s-sonya4-расход-денег-l';
import IISSonya4РегистрLForm from './forms/i-i-s-sonya4-регистр-l';
import IISSonya4ТоварыLForm from './forms/i-i-s-sonya4-товары-l';
import IISSonya4УслугиLForm from './forms/i-i-s-sonya4-услуги-l';
import IISSonya4КлиентыEForm from './forms/i-i-s-sonya4-клиенты-e';
import IISSonya4МатериалыEForm from './forms/i-i-s-sonya4-материалы-e';
import IISSonya4ПоставщикиEForm from './forms/i-i-s-sonya4-поставщики-e';
import IISSonya4ПриходДенегEForm from './forms/i-i-s-sonya4-приход-денег-e';
import IISSonya4РасходДенегEForm from './forms/i-i-s-sonya4-расход-денег-e';
import IISSonya4РегистрEForm from './forms/i-i-s-sonya4-регистр-e';
import IISSonya4ТоварыEForm from './forms/i-i-s-sonya4-товары-e';
import IISSonya4УслугиEForm from './forms/i-i-s-sonya4-услуги-e';
import IISSonya4КлиентыModel from './models/i-i-s-sonya4-клиенты';
import IISSonya4МатериалыModel from './models/i-i-s-sonya4-материалы';
import IISSonya4ПоставщикиModel from './models/i-i-s-sonya4-поставщики';
import IISSonya4ПриходДенегModel from './models/i-i-s-sonya4-приход-денег';
import IISSonya4РасходДенегModel from './models/i-i-s-sonya4-расход-денег';
import IISSonya4РегистрModel from './models/i-i-s-sonya4-регистр';
import IISSonya4СоставМатериалыModel from './models/i-i-s-sonya4-состав-материалы';
import IISSonya4СоставТовараModel from './models/i-i-s-sonya4-состав-товара';
import IISSonya4СоставТоварыModel from './models/i-i-s-sonya4-состав-товары';
import IISSonya4СоставУслугиModel from './models/i-i-s-sonya4-состав-услуги';
import IISSonya4ТоварыModel from './models/i-i-s-sonya4-товары';
import IISSonya4УслугиModel from './models/i-i-s-sonya4-услуги';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-sonya4-клиенты': IISSonya4КлиентыModel,
    'i-i-s-sonya4-материалы': IISSonya4МатериалыModel,
    'i-i-s-sonya4-поставщики': IISSonya4ПоставщикиModel,
    'i-i-s-sonya4-приход-денег': IISSonya4ПриходДенегModel,
    'i-i-s-sonya4-расход-денег': IISSonya4РасходДенегModel,
    'i-i-s-sonya4-регистр': IISSonya4РегистрModel,
    'i-i-s-sonya4-состав-материалы': IISSonya4СоставМатериалыModel,
    'i-i-s-sonya4-состав-товара': IISSonya4СоставТовараModel,
    'i-i-s-sonya4-состав-товары': IISSonya4СоставТоварыModel,
    'i-i-s-sonya4-состав-услуги': IISSonya4СоставУслугиModel,
    'i-i-s-sonya4-товары': IISSonya4ТоварыModel,
    'i-i-s-sonya4-услуги': IISSonya4УслугиModel
  },

  'application-name': 'Sonya4',

  forms: {
    loading: {
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'Sonya4',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Sonya4',
          title: 'Sonya4'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
          title: ''
        },
        sonya4: {
          caption: 'Sonya4',
          title: 'Sonya4',
          'i-i-s-sonya4-поставщики-l': {
            caption: 'Поставщики',
            title: ''
          },
          'i-i-s-sonya4-материалы-l': {
            caption: 'Материалы',
            title: ''
          },
          'i-i-s-sonya4-клиенты-l': {
            caption: 'Клиенты',
            title: ''
          },
          'i-i-s-sonya4-товары-l': {
            caption: 'Товары',
            title: ''
          },
          'i-i-s-sonya4-расход-денег-l': {
            caption: 'Расход денег',
            title: ''
          },
          'i-i-s-sonya4-услуги-l': {
            caption: 'Услуги',
            title: ''
          },
          'i-i-s-sonya4-регистр-l': {
            caption: 'Регистр',
            title: ''
          },
          'i-i-s-sonya4-приход-денег-l': {
            caption: 'Приход денег',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-sonya4-клиенты-l': IISSonya4КлиентыLForm,
    'i-i-s-sonya4-материалы-l': IISSonya4МатериалыLForm,
    'i-i-s-sonya4-поставщики-l': IISSonya4ПоставщикиLForm,
    'i-i-s-sonya4-приход-денег-l': IISSonya4ПриходДенегLForm,
    'i-i-s-sonya4-расход-денег-l': IISSonya4РасходДенегLForm,
    'i-i-s-sonya4-регистр-l': IISSonya4РегистрLForm,
    'i-i-s-sonya4-товары-l': IISSonya4ТоварыLForm,
    'i-i-s-sonya4-услуги-l': IISSonya4УслугиLForm,
    'i-i-s-sonya4-клиенты-e': IISSonya4КлиентыEForm,
    'i-i-s-sonya4-материалы-e': IISSonya4МатериалыEForm,
    'i-i-s-sonya4-поставщики-e': IISSonya4ПоставщикиEForm,
    'i-i-s-sonya4-приход-денег-e': IISSonya4ПриходДенегEForm,
    'i-i-s-sonya4-расход-денег-e': IISSonya4РасходДенегEForm,
    'i-i-s-sonya4-регистр-e': IISSonya4РегистрEForm,
    'i-i-s-sonya4-товары-e': IISSonya4ТоварыEForm,
    'i-i-s-sonya4-услуги-e': IISSonya4УслугиEForm
  },

});

export default translations;
