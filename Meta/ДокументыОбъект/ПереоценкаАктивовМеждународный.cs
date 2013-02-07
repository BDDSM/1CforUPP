
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Упр) Проверка активов, оцениваемых по справедливой стоимости
	///</summary>
	public partial class ПереоценкаАктивовМеждународный:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.ПрочиеДоходыИРасходы СтатьяПрочихДоходов;//Статья прочих доходов
		public V82.СправочникиСсылка.ПрочиеДоходыИРасходы СтатьяПрочихРасходов;//Статья прочих расходов
	}
}