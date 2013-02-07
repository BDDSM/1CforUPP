
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class ЗаданиеНаПроизводство:ДокументОбъект
	{
		public V82.Перечисления/*Ссылка*/.ВидыЗаданийНаПроизводство ВидЗадания;//Вид задания
		public DateTime ДатаЗадания;//Дата задания
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.Подразделения Подразделение;
		public V82.СправочникиСсылка.Смены Смена;
	}
}