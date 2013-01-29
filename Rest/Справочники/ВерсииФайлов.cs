
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VersiiFajjlov")]
	[Route("/Catalogs/VersiiFajjlov/{Code}")]
	public class VersiiFajjlovRequest/*������������������*/: V82.�����������������.������������,IReturn<VersiiFajjlovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VersiiFajjlovResponse//�����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VersiiFajjlovs")]
	[Route("/Catalogs/VersiiFajjlovs/{Codes}")]
	public class VersiiFajjlovsRequest/*������������������*/: IReturn<List<VersiiFajjlovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VersiiFajjlovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VersiiFajjlovsResponse//�����������������
	{
		public string Result {get;set;}
	}


	public class VersiiFajjlovService /*������������������*/ : Service
	{
		public object Any(VersiiFajjlovRequest request)
		{
			return new VersiiFajjlovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VersiiFajjlovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������.�����������(���������);
				if (������ == null)
				{
					return new VersiiFajjlovResponse() {Result = "������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������.�����������(1);
			}
		}

		public object Get(VersiiFajjlovsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������.�����������(���������);
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
