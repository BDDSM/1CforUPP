
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyNalogovykhOrganov")]
	[Route("/Catalogs/VidyNalogovykhOrganov/{Code}")]
	public class VidyNalogovykhOrganovRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<VidyNalogovykhOrganovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyNalogovykhOrganovResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyNalogovykhOrganovs")]
	[Route("/Catalogs/VidyNalogovykhOrganovs/{Codes}")]
	public class VidyNalogovykhOrganovsRequest/*��������������������������*/: IReturn<List<VidyNalogovykhOrganovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyNalogovykhOrganovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyNalogovykhOrganovsResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class VidyNalogovykhOrganovService /*��������������������������*/ : Service
	{
		public object Any(VidyNalogovykhOrganovRequest request)
		{
			return new VidyNalogovykhOrganovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyNalogovykhOrganovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyNalogovykhOrganovResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(VidyNalogovykhOrganovsRequest request)
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
