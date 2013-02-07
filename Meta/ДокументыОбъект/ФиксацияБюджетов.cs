
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
	public partial class ФиксацияБюджетов:ДокументОбъект
	{
		public V82.СправочникиСсылка.СценарииПланирования Сценарий;
		public DateTime ГраницаФиксации;//Граница фиксации
		public V82.СправочникиСсылка.Подразделения ЦФО;
		public V82.СправочникиСсылка.Проекты Проект;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
	}
}