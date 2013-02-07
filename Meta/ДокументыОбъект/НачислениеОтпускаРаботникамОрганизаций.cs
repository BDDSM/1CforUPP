
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class НачислениеОтпускаРаботникамОрганизаций:ДокументОбъект
	{
		public DateTime ПериодРегистрации;//Период регистрации
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.СотрудникиОрганизаций Сотрудник;
		public V82.СправочникиСсылка.ФизическиеЛица Физлицо;//Физическое лицо
		///<summary>
		///Дата начала события, оплачиваемого по среднему заработку
		///</summary>
		public DateTime ДатаНачалаСобытия;//Дата начала события
		public DateTime ДатаНачалаОсновногоОтпуска;//Дата начала основного отпуска
		public DateTime ДатаОкончанияОсновногоОтпуска;//Дата окончания основного отпуска
		public decimal/*(3)*/ КоличествоДнейОсновногоОтпуска;//Количество дней основного отпуска
		public V82.Перечисления/*Ссылка*/.ПорядокРасчетаОтпуска ПорядокРасчетаОсновногоОтпуска;//Порядок расчета основного отпуска
		public DateTime ДатаНачалаДополнительногоОтпуска;//Дата начала дополнительного отпуска
		public DateTime ДатаОкончанияДополнительногоОтпуска;
		public decimal/*(3)*/ КоличествоДнейДополнительногоОтпуска;//Дней дополнительного отпуска
		public object ВидРасчетаДополнительногоОтпуска;//Вид расчета дополнительного отпуска
		public decimal/*(15.2)*/ УдалитьРезультатКомпенсацииОтпуска;//Не используется
		///<summary>
		///Процент оплаты
		///</summary>
		public decimal/*(6.2)*/ ПроцентОплатыДополнительногоОтпуска;//Процент оплаты дополнительного отпуска
		public decimal/*(15.2)*/ УдалитьСторноРезультатКомпенсацииОтпуска;//Не используется
		public V82.Перечисления/*Ссылка*/.ПорядокРасчетаОтпуска ПорядокРасчетаКомпенсацииОтпуска;//Порядок расчета компенсации отпуска
		public decimal/*(5.2)*/ ДнейЧасовКомпенсацииОтпуска;//Дней часов компенсации отпуска
		public bool ИспользоватьСреднеЧасовойЗаработок;//Использовать среднечасовой заработок
		public V82.ДокументыСсылка.ПриемНаРаботуВОрганизацию УдалитьПриказ;//Удалить приказ
		public V82.ДокументыСсылка.НачислениеОтпускаРаботникамОрганизаций ПерерассчитываемыйДокумент;//Перерассчитываемый документ
		public DateTime РабочийГодС;//Рабочий год с
		public DateTime РабочийГодПо;//Рабочий год по
		public bool ОсновнойОтпуск;//Основной отпуск
		public bool ДополнительныйОтпуск;//Дополнительный отпуск
		public bool КомпенсацияОтпуска;//Компенсация отпуска
		///<summary>
		///Дата начала расчетного периода
		///</summary>
		public DateTime ПериодРасчетаСреднегоЗаработкаНачало;//Период расчета среднего заработка начало
		///<summary>
		///Дата окончания расчетного периода
		///</summary>
		public DateTime ПериодРасчетаСреднегоЗаработкаОкончание;//Период расчета среднего заработка окончание
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Фамилия;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Имя;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Отчество;
		public V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность ВидДокумента;//Вид документа
		public string/*(14)*/ СерияДокумента;//Серия документа
		public string/*(14)*/ НомерДокумента;//Номер документа
		public DateTime ДатаВыдачиДокумента;//Дата выдачи документа
		public DateTime ДатаДействияДокумента;//Дата действия документа
		public bool ПеречислятьПособиеПочтовымПереводом;//Перечислять пособие почтовым переводом
		public V82.СправочникиСсылка.Банки Банк;
		public string/*(20)*/ НомерЛицевогоСчета;//Номер лицевого счета
		public string/*(240)*/ АдресПочтовый;//Адрес почтовый
		public string/*(100)*/ НаименованиеБанка;//Наименование банка
		public string/*(9)*/ БИКБанка;//БИК банка
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьУполномоченного;//Должность уполномоченного
		public V82.СправочникиСсылка.ФизическиеЛица Уполномоченный;
		///<summary>
		///Корреспонденский счет банка
		///</summary>
		public string/*(20)*/ КоррСчетБанка;//Корр. счет банка
		public string/*(0)*/ КемВыданДокумент;//Кем выдан документ
		public string/*(240)*/ АдресРегистрации;//Адрес регистрации
		public string/*(15)*/ Телефон;
		public string/*(30)*/ ТелефонСоставителя;//Телефон составителя
	}
}