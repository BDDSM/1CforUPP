
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VariantyOtvetovOprosov")]
	[Route("/Catalogs/VariantyOtvetovOprosov/{Code}")]
	public class VariantyOtvetovOprosovRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<VariantyOtvetovOprosovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VariantyOtvetovOprosovResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VariantyOtvetovOprosovs")]
	[Route("/Catalogs/VariantyOtvetovOprosovs/{Codes}")]
	public class VariantyOtvetovOprosovsRequest/*����������������������������*/: IReturn<List<VariantyOtvetovOprosovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VariantyOtvetovOprosovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VariantyOtvetovOprosovsResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class VariantyOtvetovOprosovService /*����������������������������*/ : Service
	{
		public object Any(VariantyOtvetovOprosovRequest request)
		{
			return new VariantyOtvetovOprosovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VariantyOtvetovOprosovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new VariantyOtvetovOprosovResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(VariantyOtvetovOprosovsRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
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
