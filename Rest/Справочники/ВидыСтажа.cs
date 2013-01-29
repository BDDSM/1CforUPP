
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyStazha")]
	[Route("/Catalogs/VidyStazha/{Code}")]
	public class VidyStazhaRequest/*���������������*/: V82.�����������������.���������,IReturn<VidyStazhaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyStazhaResponse//��������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyStazhas")]
	[Route("/Catalogs/VidyStazhas/{Codes}")]
	public class VidyStazhasRequest/*���������������*/: IReturn<List<VidyStazhaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyStazhasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyStazhasResponse//��������������
	{
		public string Result {get;set;}
	}


	public class VidyStazhaService /*���������������*/ : Service
	{
		public object Any(VidyStazhaRequest request)
		{
			return new VidyStazhaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyStazhaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������.�����������(���������);
				if (������ == null)
				{
					return new VidyStazhaResponse() {Result = "��������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������.�����������(1);
			}
		}

		public object Get(VidyStazhasRequest request)
		{
			var ��������� = new List<V82.�����������������.���������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������.�����������(���������);
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
