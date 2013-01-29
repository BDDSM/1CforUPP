
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DogovoryKontragentov")]
	[Route("/Catalogs/DogovoryKontragentov/{Code}")]
	public class DogovoryKontragentovRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<DogovoryKontragentovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DogovoryKontragentovResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DogovoryKontragentovs")]
	[Route("/Catalogs/DogovoryKontragentovs/{Codes}")]
	public class DogovoryKontragentovsRequest/*��������������������������*/: IReturn<List<DogovoryKontragentovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DogovoryKontragentovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DogovoryKontragentovsResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class DogovoryKontragentovService /*��������������������������*/ : Service
	{
		public object Any(DogovoryKontragentovRequest request)
		{
			return new DogovoryKontragentovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DogovoryKontragentovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new DogovoryKontragentovResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(DogovoryKontragentovsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������.�����������(���������);
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
