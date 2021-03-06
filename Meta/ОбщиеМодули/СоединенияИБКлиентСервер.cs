﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class СоединенияИБКлиентСервер
	{
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ПРИНУДИТЕЛЬНОГО ОТКЛЮЧЕНИЯ СЕАНСОВ ИБ
		// Отключает сеанс по номеру сеанса
		//
		// Параметры
		//  ПараметрыАдминистрированияИБ  – Структура – параметры администрирования ИБ
		//  НомерСеанса - Число - номер сеанса для отключения
		//
		// Возвращаемое значение:
		//  Булево – результат отключения сеанса.
		//

		public object ОтключитьСеанс(/*НомерСеанса, Сообщение*/)
		{
			if(true/*СоединенияИБ.КоличествоСеансовИнформационнойБазы(Ложь) <= 1*/)
			{
				/*// Отключены все пользователи, кроме текущего сеанса
*/
			}
			/*// Невозможно принудительно отсоединить сеансы в файловом режиме работы
*/
			if(true/*ИнформационнаяБазаФайловая()*/)
			{
				//СоединенияИБ.ЗаписатьНазванияСоединенийИБ(НСтр("Невозможно принудительно отсоединить сеанс в файловом режиме работы"));
			}
			if(true/*ОбщегоНазначенияКлиент.КлиентПодключенЧерезВебСервер()*/)
			{
				if(true/*СоединенияИБПовтИсп.ПараметрыОтключенияСеансов().WindowsПлатформаНаСервере*/)
				{
					/*// Передаем управление на сервер
*/
				}
				/*СоединенияИБ.ЗаписатьНазванияСоединенийИБ(НСтр("Невозможно принудительно отсоединить сеанс при работе с клиента через веб-сервер,
			| если на сервере не установлена ОС Microsoft Windows"));*/
			}
			return null;
		}
		// Выполнить завершение активных сеансов.
		//
		// Возвращаемое значение:
		//   Булево   - строковый код ошибки; пустая строка - в случае успешного завершения.
		//

		public object ОтключитьСоединенияИБПоПараметрамЗапуска(/*Знач ПараметрЗапуска*/)
		{
			//ПараметрыАдминистрированияИБ = СоединенияИБПовтИсп.ПолучитьПараметрыАдминистрированияИБ();
			//Результат = ОтключитьСоединенияИБ(ПараметрыАдминистрированияИБ);
			return null;
		}
		// Отключить все активные соединения ИБ (кроме текущего сеанса).
		//
		// Параметры
		//  ПараметрыАдминистрированияИБ  – Структура – параметры администрирования ИБ.
		//
		// Возвращаемое значение:
		//   Булево   – результат отключения соединений.
		//

		public object ОтключитьСоединенияИБ(/*ПараметрыАдминистрированияИБ*/)
		{
			if(true/*СоединенияИБ.КоличествоСеансовИнформационнойБазы(Ложь) <= 1*/)
			{
				/*// Отключены все пользователи, кроме текущего сеанса
*/
			}
			/*// Невозможно принудительно отсоединить сеансы в файловом режиме работы
*/
			if(true/*ИнформационнаяБазаФайловая()*/)
			{
				//СоединенияИБ.ЗаписатьНазванияСоединенийИБ(НСтр("Невозможно принудительно отсоединить сеансы в файловом режиме работы"));
			}
			if(true/*ОбщегоНазначенияКлиент.КлиентПодключенЧерезВебСервер()*/)
			{
				if(true/*СоединенияИБПовтИсп.ПараметрыОтключенияСеансов().WindowsПлатформаНаСервере*/)
				{
					/*// Передаем управление на сервер
*/
				}
				/*СоединенияИБ.ЗаписатьНазванияСоединенийИБ(НСтр("Невозможно принудительно отсоединить сеансы при работе с клиента через веб-сервер,
			| если на сервере не установлена ОС Microsoft Windows"));*/
			}
			return null;
		}
		// Осуществляет попытку подключиться к кластеру серверов и получить список
		// активных соединений к ИБ и использованием указанных параметров администрирования.
		//
		// Параметры
		//  ПараметрыАдминистрированияИБ  – Структура – параметры администрирования ИБ
		//  ВыдаватьСообщения             – Булево    – разрешить вывод интерактивных сообщений.
		//
		// Возвращаемое значение:
		//   Булево   – Истина, если проверка завершена успешно.
		//

		public void ПроверитьПараметрыАдминистрированияИБ(/*ПараметрыАдминистрированияИБ,
	Знач ПодробноеСообщениеОбОшибке = Ложь*/)
		{
		}
		////////////////////////////////////////////////////////////////////////////////
		// СЕРВИСНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		//
		// Получить строку соединения ИБ, если задан нестандартный порт кластера серверов.
		//
		// Параметры
		//  ПортКластераСерверов  - Число - нестандартный порт кластера серверов
		//
		// Возвращаемое значение:
		//   Строка   - строка соединения ИБ
		//

		public object ПолучитьСтрокуСоединенияИнформационнойБазы(/*Знач ПортКластераСерверов = 0*/)
		{
			//Результат = СтрокаСоединенияИнформационнойБазы();
			if(true/*ИнформационнаяБазаФайловая() Или (ПортКластераСерверов = 0)*/)
			{
			}
			if(true/*ОбщегоНазначенияКлиент.КлиентПодключенЧерезВебСервер()*/)
			{
			}
			//ПодстрокиСтрокиСоединения  = СтроковыеФункцииКлиентСервер.РазложитьСтрокуВМассивПодстрок(Результат, ";");
			//ИмяСервера = СтроковыеФункцииКлиентСервер.СократитьДвойныеКавычки(Сред(ПодстрокиСтрокиСоединения[0], 7));
			//ИмяИБ      = СтроковыеФункцииКлиентСервер.СократитьДвойныеКавычки(Сред(ПодстрокиСтрокиСоединения[1], 6));
			/*Результат  = "Srvr=" + """" + ИмяСервера + 
		?(Найти(ИмяСервера, ":") > 0, "", ":" + Формат(ПортКластераСерверов, "ЧГ=0")) + """;" + 
		"Ref=" + """" + ИмяИБ + """;";*/
			return null;
		}
		// Возвращает полный путь к информационной базе (строку соединения).
		//
		// Параметры
		//  ПризнакФайловогоРежима  - Булево - выходной параметр. Принимает значение
		//                                     Истина, если текущая ИБ - файловая;
		//                                     Ложь - если клиент-серверная.
		//  ПортКластераСерверов    - Число  - входной параметр. Задается в случае, если
		//                                     кластер серверов использует нестандартный номер порта.
		//                                     Значение по умолчанию - 0, означает, что
		//                                     кластер серверов занимает номер порта по умолчанию.
		//
		// Возвращаемое значение:
		//   Строка   - строка соединения ИБ.
		//

		public object ПутьКИнформационнойБазе(/*ПризнакФайловогоРежима = Неопределено, Знач ПортКластераСерверов = 0*/)
		{
			//СтрокаСоединения = ПолучитьСтрокуСоединенияИнформационнойБазы(ПортКластераСерверов);
			//ПозицияПоиска = Найти(Врег(СтрокаСоединения), "FILE=");
			if(true/*ПозицияПоиска = 1*/)
			{
				/*// файловая ИБ
*/
				//ПутьКИБ = Сред(СтрокаСоединения, 6, СтрДлина(СтрокаСоединения) - 6);
				//ПризнакФайловогоРежима = Истина;
			}
			return null;
		}
		// Получить пустую структуру параметров администрирования кластера серверов.
		//
		// Возвращаемое значение:
		//   Структура – с полями:
		//     ИмяАдминистратораКластера
		//     ПарольАдминистратораКластера
		//     ПортКластераСерверов
		//     ПортАгентаСервера
		//

		public object НовыеПараметрыАдминистрированияИБ(/*Знач ИмяАдминистратораКластера = "",
	Знач ПарольАдминистратораКластера = "", Знач ПортКластераСерверов = 0, 
	Знач ПортАгентаСервера = 0*/)
		{
			return null;
		}
		// Возвращает текстовую константу для формирования сообщений.
		// Используется в целях локализации.
		//

		public object ТекстДляАдминистратора(/**/)
		{
			//Возврат НСтр("ru = 'Для администратора:'");
			return null;
		}
		// Возвращает пользовательский текст сообщения блокировки сеансов.
		//

		public object ИзвлечьСообщениеБлокировки(/*Знач Сообщение*/)
		{
			//ИндексМаркера = Найти(Сообщение, ТекстДляАдминистратора());
			if(true/*ИндексМаркера = 0*/)
			{
			}
			return null;
		}
		// Возвращает строковую константу для формирования сообщений журнала регистрации.
		//
		// Возвращаемое значение:
		//   Строка
		//

		public object СобытиеЖурналаРегистрации(/**/)
		{
			//Возврат НСтр("ru = 'Завершение работы пользователей'");
			return null;
		}

		public object ПолучитьАктивныеСеансыИБ(/*НастройкаБлокировки, знач ВсеКромеТекущего = Истина*/)
		{
			//Результат = Новый Структура("АгентСервера,КластерСерверов,Сеансы", Неопределено, Неопределено, Новый Массив);
			/*ПодстрокиСтрокиСоединения = СтроковыеФункцииКлиентСервер.РазложитьСтрокуВМассивПодстрок(
		СтрокаСоединенияИнформационнойБазы(), ";");*/
			//ИмяСервера = СтроковыеФункцииКлиентСервер.СократитьДвойныеКавычки(Сред(ПодстрокиСтрокиСоединения[0], 7));
			//ИмяИБ      = СтроковыеФункцииКлиентСервер.СократитьДвойныеКавычки(Сред(ПодстрокиСтрокиСоединения[1], 6));
			//COMСоединитель = Новый COMОбъект(ОбщегоНазначения.ИмяCOMСоединителя());
			//РазделительПорта = Найти(ИмяСервера, ":");
			if(true/*РазделительПорта > 0*/)
			{
				//ИмяИПортСервера = ИмяСервера;
				//ИмяСервера = Сред(ИмяИПортСервера, 1, РазделительПорта - 1);
				//НомерПортаКластера = Число(Сред(ИмяИПортСервера, РазделительПорта + 1));
			}
			//ИдентификаторАгентаСервера = ИмяСервера;
			if(true/*НастройкаБлокировки.ПортАгентаСервера <> 0*/)
			{
				/*ИдентификаторАгентаСервера = ИдентификаторАгентаСервера + ":" + 
			Формат(НастройкаБлокировки.ПортАгентаСервера, "ЧГ=0");*/
			}
			/*// Подключение к агенту сервера
*/
			//АгентСервера = COMСоединитель.ConnectAgent(ИдентификаторАгентаСервера);
			//Результат.АгентСервера = АгентСервера;
			/*// Найдем необходимый нам кластер
*/
			return null;
		}

		public object ЗавершитьСеанс(/*ПараметрыСоединенияССервером1СПредприятие, Знач НомерСеансаДляЗавершения*/)
		{
			//Результат = Новый Структура("СоединениеСРабочимПроцессом, Соединения", Неопределено, Новый Массив);
			if(true/*ИнформационнаяБазаФайловая()*/)
			{
				//ВызватьИсключение НСтр("ru = 'Невозможно получить список активных соединений в файловом режиме работы'");
			}
			if(true/*ОбщегоНазначенияКлиент.КлиентПодключенЧерезВебСервер()*/)
			{
				//ВызватьИсключение НСтр("ru = 'Невозможно получить список активных соединений при работе через веб-сервер'");
			}
			/*ПодстрокиСтрокиСоединения = СтроковыеФункцииКлиентСервер.РазложитьСтрокуВМассивПодстрок(
		СтрокаСоединенияИнформационнойБазы(), ";");*/
			//ИмяСервера = СтроковыеФункцииКлиентСервер.СократитьДвойныеКавычки(Сред(ПодстрокиСтрокиСоединения[0], 7));
			//ИмяИБ      = СтроковыеФункцииКлиентСервер.СократитьДвойныеКавычки(Сред(ПодстрокиСтрокиСоединения[1], 6));
			//COMСоединитель = Новый COMОбъект(ОбщегоНазначения.ИмяCOMСоединителя());
			//РазделительПорта = Найти(ИмяСервера, ":");
			if(true/*РазделительПорта > 0*/)
			{
				//ИмяИПортСервера = ИмяСервера;
				//ИмяСервера = Сред(ИмяИПортСервера, 1, РазделительПорта - 1);
				//НомерПортаКластера = Число(Сред(ИмяИПортСервера, РазделительПорта + 1));
			}
			//ИдентификаторАгентаСервера = ИмяСервера;
			if(true/*ПараметрыСоединенияССервером1СПредприятие.ПортАгентаСервера <> 0*/)
			{
				/*ИдентификаторАгентаСервера = ИдентификаторАгентаСервера + ":" + 
		  	Формат(ПараметрыСоединенияССервером1СПредприятие.ПортАгентаСервера, "ЧГ=0");*/
			}
			/*// Подключение к агенту сервера
*/
			//АгентСервера = COMСоединитель.ConnectAgent(ИдентификаторАгентаСервера);
			/*// Найдем необходимый нам кластер
*/
			return null;
		}

		public object ИнформационнаяБазаФайловая(/**/)
		{
			//Результат = СтандартныеПодсистемыКлиентПовтИсп.ПараметрыРаботыКлиента().ИнформационнаяБазаФайловая;
			//Результат = ОбщегоНазначения.ИнформационнаяБазаФайловая();
			return null;
		}

		public void ЗаписатьСобытие(/*Знач ТекстСобытия, ПредставлениеУровня = "Информация", Записать = Истина*/)
		{
			/*ОбщегоНазначенияКлиент.ДобавитьСообщениеДляЖурналаРегистрации(СобытиеЖурналаРегистрации(),
		ПредставлениеУровня, ТекстСобытия,,Записать);*/
			/*ЗаписьЖурналаРегистрации(СобытиеЖурналаРегистрации(), 
		ПредопределенноеЗначение("УровеньЖурналаРегистрации." + ПредставлениеУровня),,, ТекстСобытия);*/
		}
	}
}
