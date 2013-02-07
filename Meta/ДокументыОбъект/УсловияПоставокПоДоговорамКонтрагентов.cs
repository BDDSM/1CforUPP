
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Упр)
	///</summary>
	public partial class УсловияПоставокПоДоговорамКонтрагентов:ДокументОбъект
	{
		public DateTime ДатаНачала;//Дата начала
		public DateTime ДатаОкончания;//Дата окончания
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		public V82.Перечисления/*Ссылка*/.Периодичность Периодичность;
		public decimal/*(15.2)*/ СуммаУсловийДоговора;//Сумма условий договора
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
	}
}