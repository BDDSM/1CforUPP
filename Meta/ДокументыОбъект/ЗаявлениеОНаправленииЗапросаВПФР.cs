
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class ЗаявлениеОНаправленииЗапросаВПФР:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.СотрудникиОрганизаций Сотрудник;
		public V82.СправочникиСсылка.ФизическиеЛица ФизЛицо;//Физическое лицо
		public V82.СправочникиСсылка.Работодатели Страхователь;
		public V82.Перечисления/*Ссылка*/.ВидыПособийСоциальногоСтрахования ВидПособия;//Вид пособия
		public DateTime ПериодРаботыС;//Период работы С
		public DateTime ПериодРаботыПо;//Период работы по
		public bool СтраховательПрекратилДеятельность;//Страхователь прекратил деятельность
		public string/*(0)*/ ИныеПричиныОтсутствияСправки;//Иные причины отсутствия справки
		public string/*(14)*/ СтраховойНомерПФР;//Страховой номер ПФР
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаРождения;//Дата рождения
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
		public string/*(240)*/ Адрес;
		public string/*(240)*/ Телефон;
		public V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность ВидДокумента;//Вид документа
		public string/*(14)*/ СерияДокумента;//Серия документа
		public string/*(14)*/ НомерДокумента;//Номер документа
		public DateTime ДатаВыдачиДокумента;//Дата выдачи документа
		public string/*(0)*/ КемВыданДокумент;//Кем выдан документ
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
	}
}