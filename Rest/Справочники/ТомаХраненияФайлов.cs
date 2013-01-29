
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/TomaKHraneniyaFajjlov")]
	[Route("/Catalogs/TomaKHraneniyaFajjlov/{Code}")]
	public class TomaKHraneniyaFajjlovRequest/*������������������������*/: V82.�����������������.������������������,IReturn<TomaKHraneniyaFajjlovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class TomaKHraneniyaFajjlovResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/TomaKHraneniyaFajjlovs")]
	[Route("/Catalogs/TomaKHraneniyaFajjlovs/{Codes}")]
	public class TomaKHraneniyaFajjlovsRequest/*������������������������*/: IReturn<List<TomaKHraneniyaFajjlovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public TomaKHraneniyaFajjlovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class TomaKHraneniyaFajjlovsResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class TomaKHraneniyaFajjlovService /*������������������������*/ : Service
	{
		public object Any(TomaKHraneniyaFajjlovRequest request)
		{
			return new TomaKHraneniyaFajjlovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(TomaKHraneniyaFajjlovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new TomaKHraneniyaFajjlovResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(TomaKHraneniyaFajjlovsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
